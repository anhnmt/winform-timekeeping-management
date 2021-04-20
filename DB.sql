USE master
--
-- GO
--
-- -- DROP DATABASE IF EXISTS Timekeeping
--
GO

CREATE DATABASE Timekeeping

GO

USE Timekeeping

GO

-- Bảng Positions (Chức vụ)
CREATE TABLE Positions
(
    position_id int PRIMARY KEY IDENTITY,
    name          varchar(20) NOT NULL UNIQUE,
	basic_salary float NOT NULL
)

GO

-- Bảng Employees (Nhân viên)
CREATE TABLE Employees
(
    employee_id   int PRIMARY KEY IDENTITY,
    name          nvarchar(255) NOT NULL,
    email         varchar(255)  NOT NULL UNIQUE,
    phone         varchar(20)   NOT NULL UNIQUE,
    [password]    varchar(255)  NOT NULL,
    [address]     nvarchar(255) NOT NULL,
    birthday      date          NOT NULL,
    gender        bit           NOT NULL, -- 1 = Male, 2 = Female
    coefficients_salary        float         NOT NULL,
	avatar varchar(max),
    position_id int FOREIGN KEY REFERENCES Positions (position_id),
)

GO

-- Bảng Holidays (Ngày nghỉ)
CREATE TABLE Holidays
(
    holiday_id      int PRIMARY KEY IDENTITY,
    [start_date]	date NOT NULL DEFAULT(GETDATE()),
    [end_date]		date NOT NULL DEFAULT(GETDATE()),
	[description]	nvarchar(max)
)

GO

CREATE PROC sp_insertHoliday
(
    @_start_date	date = GETDATE,
    @_end_date		date = GETDATE,
	@_description	nvarchar(max) = '',
    @_outStt		BIT = 1 OUTPUT,
    @_outMsg		NVARCHAR(200) = '' OUTPUT
)
AS
BEGIN TRY
    BEGIN TRAN;

	-- Kiểm tra thông tin nhân viên
	IF EXISTS (SELECT [start_date] FROM Holidays WHERE [start_date] = @_start_date)
    BEGIN
        SET @_outStt = 0;
        SET @_outMsg = N'Ngày bắt đầu nghỉ: ' + CAST(@_start_date AS VARCHAR(10)) + ' đã tồn tại, vui lòng nhập lại';
    END;
	ELSE IF EXISTS (SELECT [end_date] FROM Holidays WHERE [end_date] = @_end_date)
    BEGIN
        SET @_outStt = 0;
        SET @_outMsg = N'Ngày kết thúc nghỉ: ' + CAST(@_end_date AS VARCHAR(10)) + ' đã tồn tại, vui lòng nhập lại';
    END;
    ELSE
    BEGIN
        INSERT INTO Holidays([start_date], [end_date], [description]) VALUES (@_start_date, @_end_date, @_description)

        SET @_outStt = 1;
        SET @_outMsg = N'Thêm ngày nghỉ thành công';

        IF @@TRANCOUNT > 0
            COMMIT TRAN;
    END;
END TRY
BEGIN CATCH
    SET @_outStt = 0;
    SET @_outMsg = N'Thêm ngày nghỉ thất bại: ' + ERROR_MESSAGE();

    IF @@TRANCOUNT > 0
        ROLLBACK TRAN;
END CATCH;

GO

EXEC sp_insertHoliday '2021-04-21', '2021-04-21', N'Nghỉ giỗ tổ Hùng vương năm 2021'
EXEC sp_insertHoliday '2021-04-30', '2021-05-03', N'Nghỉ 30/04 - 01/05 năm 2021'

GO

-- Bảng Schedules (Chấm công)
CREATE TABLE Schedules
(
    schedule_id     int PRIMARY KEY IDENTITY,
    working_date	date NOT NULL,
    is_holiday      bit DEFAULT (0),
    is_weekend      bit DEFAULT (0),
    employee_id     int FOREIGN KEY REFERENCES Employees (employee_id),
)

GO

-- Bảng ScheduleDetails (Chi tiết chấm công)
CREATE TABLE ScheduleDetails
(
    schedule_id			int NOT NULL FOREIGN KEY REFERENCES Schedules (schedule_id),
    start_work_hour		datetime NOT NULL DEFAULT(GETDATE()),
    end_work_hour		datetime default(null),
	minute_work_late	int DEFAULT(0),
	minute_orvertime	int DEFAULT(0)
)

GO

CREATE PROC sp_loadSchedule
(
	@_department_id INT,
    @_employee_id     int,
    @_outStt BIT = 1 OUTPUT,
    @_outMsg NVARCHAR(200) = '' OUTPUT
)
AS
BEGIN TRY
    BEGIN TRAN;

	DECLARE @_working_date date = GETDATE(),
			@_is_holiday bit = 0,
			@_is_weekend bit = 0

	-- Kiểm tra ngày cuối tuần
	if (DATEADD(DAY,  6 - DATEPART(WEEKDAY, @_working_date), @_working_date) = @_working_date or DATEADD(DAY,  7 - DATEPART(WEEKDAY, @_working_date), @_working_date) = @_working_date)
		SET @_is_weekend = 1

	-- Kiểm tra ngày nghỉ lễ
	IF EXISTS (SELECT [start_date], [end_date] FROM Holidays WHERE [start_date] = @_working_date or [end_date] = @_working_date)
		SET @_is_holiday = 1

	-- Kiểm tra thông tin nhân viên
	IF NOT EXISTS (SELECT name FROM Employees WHERE employee_id = @_employee_id)
    BEGIN
        SET @_outStt = 0;
        SET @_outMsg = N'Nhân viên không tồn tại, vui lòng nhập lại';
    END;
	-- Kiểm tra nhân viên chưa chấm công trong ngày hiện tại
    ELSE IF NOT EXISTS (select * from Schedules where employee_id = @_employee_id and working_date = @_working_date)
    BEGIN
        insert into Schedules(working_date, is_holiday, is_weekend, employee_id) values (@_working_date, @_is_holiday, @_is_weekend, @_employee_id)

        insert into ScheduleDetails(schedule_id, start_work_hour, end_work_hour, minute_work_late, minute_orvertime) values (SCOPE_IDENTITY(), start_work_hour, end_work_hour, minute_work_late, minute_orvertime)

        SET @_outStt = 1;
        SET @_outMsg = N'Chấm công thành công';

        IF @@TRANCOUNT > 0
            COMMIT TRAN;
    END;
    ELSE
    BEGIN
        BEGIN TRAN;
        UPDATE Departments
		SET 
            [name] = @_name
		WHERE department_id = @_department_id;

        SET @_outStt = 1;
        SET @_outMsg = N'Chấm công thành công';

        IF @@TRANCOUNT > 0
            COMMIT TRAN;
    END;
END TRY
BEGIN CATCH
    SET @_outStt = 0;
    SET @_outMsg = N'Chấm công không thành công: ' + ERROR_MESSAGE();

    IF @@TRANCOUNT > 0
        ROLLBACK TRAN;
END CATCH;

GO

-- Bảng Salaries (Bảng lương)
CREATE TABLE Salaries
(
    employee_id     int FOREIGN KEY REFERENCES Employees (employee_id),
    schedule_id		int FOREIGN KEY REFERENCES Schedules (schedule_id),
	total			float DEFAULT(0)

)