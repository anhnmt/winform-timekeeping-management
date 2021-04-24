USE master
--
-- GO
--
-- -- DROP DATABASE IF EXISTS Timekeeping
--
GO

-- CREATE DATABASE Timekeeping

GO

USE Timekeeping

GO

-- Bảng Positions (Chức vụ)
CREATE TABLE Positions
(
    position_id  int PRIMARY KEY IDENTITY,
    name         nvarchar(50) NOT NULL UNIQUE,
    basic_salary float        NOT NULL
)

GO

-- PROC thêm chức vụ
CREATE PROC sp_createPosition(
    @_name nvarchar(20),
    @_basic_salary float,
    @_outStt BIT = 1 OUTPUT,
    @_outMsg NVARCHAR(200) = '' OUTPUT
)
AS
BEGIN TRY
    IF EXISTS(SELECT name FROM Positions WHERE name = @_name)
        BEGIN
            SET @_outStt = 0;
            SET @_outMsg = N'Chức vụ đã tồn tại, vui lòng nhập lại';
        END;
    ELSE
        BEGIN
            BEGIN TRAN;
            INSERT INTO Positions
                (name, basic_salary)
            VALUES (@_name, @_basic_salary);

            SET @_outStt = 1;
            SET @_outMsg = N'Thêm chức vụ thành công';

            IF @@TRANCOUNT > 0
                COMMIT TRAN;
        END;
END TRY
BEGIN CATCH
    SET @_outStt = 0;
    SET @_outMsg = N'Thêm không thành công: ' + ERROR_MESSAGE();

    IF @@TRANCOUNT > 0
        ROLLBACK TRAN;
END CATCH;
GO

EXEC sp_createPosition @_name = N'Giám đốc', @_basic_salary = 15000000
EXEC sp_createPosition @_name = N'Quản lý', @_basic_salary = 8000000
EXEC sp_createPosition @_name = N'Nhân viên', @_basic_salary = 5000000

GO

-- Bảng Employees (Nhân viên)
CREATE TABLE Employees
(
    employee_id         int PRIMARY KEY IDENTITY,
    position_id         int FOREIGN KEY REFERENCES Positions (position_id),
    name                nvarchar(255) NOT NULL,
    email               varchar(255)  NOT NULL UNIQUE,
    phone               varchar(20)   NOT NULL UNIQUE,
    [password]          varchar(255)  NOT NULL,
    [address]           nvarchar(255) NOT NULL,
    birthday            date          NOT NULL,
    gender              bit           NOT NULL, -- 1 = Male, 0 = Female
    coefficients_salary float         NOT NULL,
    avatar              varchar(max),
    status              int DEFAULT (1)         -- Active: 1, Disabled: 0
)

GO

-- PROC thêm nhân viên
CREATE PROC sp_createEmployee(
    @_name nvarchar(255),
    @_email varchar(255),
    @_password varchar(255),
    @_phone varchar(20),
    @_address nvarchar(255),
    @_birthday date,
    @_gender bit = 1,
    @_coefficients_salary float,
    @_avatar varchar(max) = '',
    @_position_id int,
    @_outStt BIT = 1 OUTPUT,
    @_outMsg NVARCHAR(200) = '' OUTPUT
)
AS
BEGIN TRY
    IF EXISTS(SELECT name FROM Employees WHERE email = @_email)
        BEGIN
            SET @_outStt = 0;
            SET @_outMsg = N'Email đã tồn tại, vui lòng nhập lại';
        END;
    ELSE
        IF EXISTS(SELECT name FROM Employees WHERE phone = @_phone)
            BEGIN
                SET @_outStt = 0;
                SET @_outMsg = N'Số điện thoại đã tồn tại, vui lòng nhập lại';
            END;
        ELSE
            IF NOT EXISTS(SELECT position_id FROM Positions WHERE position_id = @_position_id)
                BEGIN
                    SET @_outStt = 0;
                    SET @_outMsg = N'Chức vụ không tồn tại, vui lòng nhập lại';
                END;
            ELSE
                BEGIN
                    BEGIN TRAN;
                    INSERT INTO Employees
                    (name, email, phone, [password], [address], birthday, gender, coefficients_salary, avatar,
                     position_id)
                    VALUES (@_name, @_email, @_phone, @_password, @_address, CAST(@_birthday AS DATE), @_gender,
                            @_coefficients_salary, @_avatar,
                            @_position_id);

                    SET @_outStt = 1;
                    SET @_outMsg = N'Thêm nhân viên thành công';

                    IF @@TRANCOUNT > 0
                        COMMIT TRAN;
                END;
END TRY
BEGIN CATCH
    SET @_outStt = 0;
    SET @_outMsg = N'Thêm không thành công: ' + ERROR_MESSAGE();

    IF @@TRANCOUNT > 0
        ROLLBACK TRAN;
END CATCH;

GO

EXEC sp_createEmployee @_name = N'Giám Văn Đốc',
     @_email = 'sa@gmail.com',
     @_password = '123456',
     @_phone = '0987839382',
     @_address = N'Hà Nội',
     @_birthday = '1999-12-26',
     @_coefficients_salary = 5,
     @_position_id = 1


EXEC sp_createEmployee @_name = N'Quản Văn Lý',
     @_email = 'admin@gmail.com',
     @_password = '123456',
     @_phone = '0123456789',
     @_address = N'Nha Trang',
     @_birthday = '2004-12-14',
     @_coefficients_salary = 3,
     @_position_id = 2

EXEC sp_createEmployee @_name = N'Nhân Thị Viên',
     @_email = 'user@gmail.com',
     @_password = '123456',
     @_phone = '0987654321',
     @_address = N'Hồ Chí Minh',
     @_birthday = '2000-12-01',
     @_gender = 0,
     @_coefficients_salary = 3,
     @_position_id = 3

GO

-- Bảng Holidays (Ngày nghỉ)
CREATE TABLE Holidays
(
    holiday_id    int PRIMARY KEY IDENTITY,
    [start_date]  date NOT NULL DEFAULT (GETDATE()),
    [end_date]    date NOT NULL DEFAULT (GETDATE()),
    [description] nvarchar(max),
    status        int           DEFAULT (1) -- Active: 1, Disabled: 0
)

GO

CREATE PROC sp_insertHoliday(
    @_start_date date = NULL,
    @_end_date date = NULL,
    @_description nvarchar(max) = '',
    @_outStt BIT = 1 OUTPUT,
    @_outMsg NVARCHAR(200) = '' OUTPUT
)
AS
BEGIN TRY
    SET @_start_date = ISNULL(@_start_date, GETDATE())
    SET @_end_date = ISNULL(@_end_date, GETDATE())

    -- Kiểm tra thông tin nhân viên
    IF EXISTS(SELECT [start_date] FROM Holidays WHERE [start_date] = @_start_date)
        BEGIN
            SET @_outStt = 0;
            SET @_outMsg =
                        N'Ngày bắt đầu nghỉ: ' + CAST(@_start_date AS VARCHAR(10)) + ' đã tồn tại, vui lòng nhập lại';
        END;
    ELSE
        IF EXISTS(SELECT [end_date] FROM Holidays WHERE [end_date] = @_end_date)
            BEGIN
                SET @_outStt = 0;
                SET @_outMsg = N'Ngày kết thúc nghỉ: ' + CAST(@_end_date AS VARCHAR(10)) +
                               ' đã tồn tại, vui lòng nhập lại';
            END;
        ELSE
            BEGIN
                BEGIN TRAN;
                INSERT INTO Holidays([start_date], [end_date], [description])
                VALUES (@_start_date, @_end_date, @_description)

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
    schedule_id      int PRIMARY KEY IDENTITY,
    working_date     date     NOT NULL,                                 -- Ngày làm việc
    is_holiday       bit               DEFAULT (0),                     -- Ngày nghỉ, lễ
    is_weekend       bit               DEFAULT (0),                     -- Ngày cuối tuần
    workday          float             DEFAULT (1),                     -- Số công trong ngày
    start_work_hour  datetime NOT NULL DEFAULT (GETDATE()),             -- Giờ vào làm
    end_work_hour    datetime          DEFAULT (NULL),                  -- Giờ ra về
    hour_work_late   int               DEFAULT (0),                     -- Số giờ đi muộn
    hour_leave_early int               DEFAULT (0),                     -- Số giờ về sớm
    employee_id      int FOREIGN KEY REFERENCES Employees (employee_id) -- Mã nhân viên
)

GO

-- Procedure chấm công
CREATE PROC sp_loadSchedule(
    @_employee_id int,
    @_working_date date = NULL,
    @_start_work_hour datetime = NULL,
    @_end_work_hour datetime = NULL,
    @_outStt BIT = 1 OUTPUT,
    @_outMsg NVARCHAR(200) = '' OUTPUT
)
AS
BEGIN TRY
    DECLARE
        @_is_holiday bit = 0,
        @_is_weekend bit = 0,
        @_hour_work_late int = 0,
        @_hour_leave_early int = 0,
        @_workday float = 1

    -- Nếu giờ hiện tại > 08:00
    IF GETDATE() > DATEADD(HOUR, 8, DATEADD(DAY, DATEDIFF(DAY, 0, GETDATE()), 0))
        SET @_hour_work_late = DATEDIFF(HOUR, DATEADD(HOUR, 8, DATEADD(DAY, DATEDIFF(DAY, 0, GETDATE()), 0)), GETDATE())

    -- Nếu giờ hiện tại < 17:00
    IF GETDATE() < DATEADD(HOUR, 17, DATEADD(DAY, DATEDIFF(DAY, 0, GETDATE()), 0))
        SET @_hour_leave_early =
                DATEDIFF(HOUR, GETDATE(), DATEADD(HOUR, 17, DATEADD(DAY, DATEDIFF(DAY, 0, GETDATE()), 0)))

    SET @_working_date = ISNULL(@_working_date, GETDATE())
    SET @_start_work_hour = ISNULL(@_start_work_hour, GETDATE())
    SET @_end_work_hour = ISNULL(@_end_work_hour, GETDATE())

    -- Kiểm tra ngày cuối tuần
    IF (DATEADD(DAY, 6 - DATEPART(WEEKDAY, @_working_date), @_working_date) = @_working_date OR
        DATEADD(DAY, 7 - DATEPART(WEEKDAY, @_working_date), @_working_date) = @_working_date)
        SET @_is_weekend = 1

    -- Kiểm tra ngày nghỉ lễ
    IF EXISTS(SELECT [start_date], [end_date]
              FROM Holidays
              WHERE [status] = 1 AND [start_date] = @_working_date
                 OR [end_date] = @_working_date)
        SET @_is_holiday = 1

    -- Kiểm tra thông tin nhân viên
    IF NOT EXISTS(SELECT name FROM Employees WHERE employee_id = @_employee_id)
        BEGIN
            SET @_outStt = 0;
            SET @_outMsg = N'Nhân viên không tồn tại, vui lòng nhập lại';
        END;
    ELSE
        -- Kiểm tra nhân viên chưa chấm công trong ngày hiện tại
        IF NOT EXISTS(
                SELECT schedule_id FROM Schedules WHERE employee_id = @_employee_id AND working_date = @_working_date)
            BEGIN
                BEGIN TRAN;

                -- Thưởng công ngày nghỉ, lễ hoặc cuối tuần
                IF @_is_holiday = 1 OR @_is_weekend = 1
                    SET @_workday = @_workday + 1

                -- Trừ công đi muộn
                IF @_hour_work_late > 0
                    SET @_workday = @_workday - (@_hour_work_late * 0.1)

                PRINT @_hour_work_late
                PRINT @_workday

                -- Chấm công
                INSERT INTO Schedules(working_date, is_holiday, is_weekend, workday, start_work_hour, hour_work_late,
                                      employee_id)
                VALUES (@_working_date, @_is_holiday, @_is_weekend, ROUND(@_workday, 1), @_start_work_hour,
                        @_hour_work_late, @_employee_id)

                SET @_outStt = 1;
                SET @_outMsg = N'Chấm công thành công';

                IF @@TRANCOUNT > 0
                    COMMIT TRAN;
            END;
        ELSE
            BEGIN
                BEGIN TRAN;

                DECLARE @_schedule_id int = (SELECT schedule_id
                                             FROM Schedules
                                             WHERE employee_id = @_employee_id
                                               AND working_date = @_working_date);
                SET @_workday = (SELECT workday
                                 FROM Schedules
                                 WHERE schedule_id = @_schedule_id)

                -- Trừ công về sớm
                IF @_hour_leave_early > 0
                    SET @_workday = @_workday - (@_hour_leave_early * 0.1)

                -- Nếu công trong ngày <= 0.2 (Ngày làm 8 tiếng = 1 - 0.8)
                IF (@_workday <= 0.2)
                    SET @_workday = 0

                -- Cập nhật công, thời gian khi checkout
                UPDATE Schedules
                SET workday          = ROUND(@_workday, 1),
                    end_work_hour    = @_end_work_hour,
                    hour_leave_early = @_hour_leave_early
                WHERE schedule_id = @_schedule_id;

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

EXEC sp_loadSchedule @_employee_id = 2
    , @_working_date = '2021-04-22'
    , @_start_work_hour = '2021-04-22 8:29:00'
    , @_end_work_hour = '2021-04-22 23:29:00'

GO

-- Bảng Approvals (Đơn từ)
CREATE TABLE Approvals
(
    approval_id int PRIMARY KEY IDENTITY,
    employee_id int FOREIGN KEY REFERENCES Employees (employee_id),
    start_date  datetime NOT NULL DEFAULT (GETDATE()),
    end_date    datetime NOT NULL DEFAULT (GETDATE()),
    status      int               DEFAULT (2) -- Waiting: 2, Active: 1, Disabled: 0
)

