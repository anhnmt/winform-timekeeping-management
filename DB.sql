-- USE master
--
-- GO
--
-- -- DROP DATABASE IF EXISTS Timekeeping
--
-- GO
--
-- CREATE DATABASE Timekeeping

GO

USE Timekeeping

GO

-- Bảng Department (Phòng ban)
CREATE TABLE Departments
(
    department_id int PRIMARY KEY IDENTITY,
    name          varchar(20) NOT NULL UNIQUE,
    [description] nvarchar(max)
)

GO

-- PROC thêm phòng ban
CREATE PROC sp_createDepartment(
    @_name varchar(20),
    @_description nvarchar(max) = '',
    @_outStt BIT = 1 OUTPUT,
    @_outMsg NVARCHAR(200) = '' OUTPUT
)
AS
BEGIN TRY
    IF EXISTS(SELECT name FROM Departments WHERE name = @_name)
        BEGIN
            SET @_outStt = 0;
            SET @_outMsg = N'Tên phòng ban đã tồn tại, vui lòng nhập lại';
        END;
    ELSE
        BEGIN
            BEGIN TRAN;
            INSERT INTO Departments
                (name, description)
            VALUES (@_name, @_description);

            SET @_outStt = 1;
            SET @_outMsg = N'Thêm phòng ban thành công';

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

EXEC sp_createDepartment @_name = 'ADMIN', @_description = N'Ban quản trị'
EXEC sp_createDepartment @_name = 'HR', @_description = N'Phòng nhân sự'
EXEC sp_createDepartment @_name = 'DEV', @_description = N'Phòng kỹ thuật'
EXEC sp_createDepartment @_name = 'ACCOUNTANT', @_description = N'Phòng kế toán'

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
    salary        float         NOT NULL,
    department_id int FOREIGN KEY REFERENCES Departments (department_id),
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
    @_salary float,
    @_department_id int,
    @_outStt BIT = 1 OUTPUT,
    @_outMsg NVARCHAR(200) = '' OUTPUT
)
AS
BEGIN TRY
    IF EXISTS(SELECT email FROM Employees WHERE email = @_email)
        BEGIN
            SET @_outStt = 0;
            SET @_outMsg = N'Email đã tồn tại, vui lòng nhập lại';
        END;
    ELSE
        IF EXISTS(SELECT phone FROM Employees WHERE phone = @_phone)
            BEGIN
                SET @_outStt = 0;
                SET @_outMsg = N'Số điện thoại đã tồn tại, vui lòng nhập lại';
            END;
        ELSE
            IF NOT EXISTS(SELECT department_id FROM Departments WHERE department_id = @_department_id)
                BEGIN
                    SET @_outStt = 0;
                    SET @_outMsg = N'Phòng ban không tồn tại, vui lòng nhập lại';
                END;
            ELSE
                BEGIN
                    BEGIN TRAN;
                    INSERT INTO Employees
                    (name, email, phone, [password], [address], birthday, gender, salary,
                     department_id)
                    VALUES (@_name, @_email, @_phone, @_password, @_address, CAST(@_birthday AS DATE), @_gender, @_salary,
                            @_department_id);

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

EXEC sp_createEmployee @_name = N'Nguyễn Mạnh Tuấn Anh',
     @_email = 'anhnmt@gmail.com',
     @_password = '123456',
     @_phone = '0987839382',
     @_address = N'Hà Nội',
     @_birthday = '1999-12-26',
     @_gender = 1,
     @_salary = 20000000,
     @_department_id = 1

EXEC sp_createEmployee @_name = N'Nguyễn Tuấn Minh',
     @_email = 'minhnt@gmail.com',
     @_password = '123456',
     @_phone = '0394868698',
     @_address = N'Hà Nội',
     @_birthday = '2004-12-14',
     @_gender = 1,
     @_salary = 8000000,
     @_department_id = 4

GO

-- Bảng Schedules (Chấm công)
CREATE TABLE Schedules
(
    id              int PRIMARY KEY IDENTITY,
    start_work_hour datetime NOT NULL,
    end_work_hour   datetime NOT NULL,
    is_holiday      bit DEFAULT (0),
    is_weekend      bit DEFAULT (0),
    employee_id     int FOREIGN KEY REFERENCES Employees (employee_id),
)

GO