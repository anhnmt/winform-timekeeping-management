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
    schedule_id			int FOREIGN KEY REFERENCES Schedules (schedule_id),
    start_work_hour		datetime NOT NULL,
    end_work_hour		datetime NOT NULL,
	minute_work_late	int DEFAULT(0),
	minute_orvertime	int DEFAULT(0)
)

GO

-- Bảng Salaries (Bảng lương)
CREATE TABLE Salaries
(
    employee_id     int FOREIGN KEY REFERENCES Employees (employee_id),
    schedule_id		int FOREIGN KEY REFERENCES Schedules (schedule_id),
	total			float DEFAULT(0)
)