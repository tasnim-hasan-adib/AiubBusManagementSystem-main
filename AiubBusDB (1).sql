/* =====================================================================
   AiubBusDB - database script for AiubBusManagementSystem
   Source project : github.com/morsalin1310/AiubBusManagementSystem
   Prepared with  : AI assistance (Claude), derived from the SQL queries
                    in the project's Repositories folder (.cs files).
   Target         : SQL Server / LocalDB  ((localdb)\MSSQLLocalDB)
   Safe to re-run : drops and recreates all tables.
   ===================================================================== */

IF DB_ID('AiubBusDB') IS NULL
    CREATE DATABASE AiubBusDB;
GO

USE AiubBusDB;
GO

/* ---------- Drop old tables (child tables first) ---------- */
IF OBJECT_ID('dbo.TravelLogs', 'U')               IS NOT NULL DROP TABLE dbo.TravelLogs;
IF OBJECT_ID('dbo.StudentPickupSelections', 'U')  IS NOT NULL DROP TABLE dbo.StudentPickupSelections;
IF OBJECT_ID('dbo.BusAssignments', 'U')           IS NOT NULL DROP TABLE dbo.BusAssignments;
IF OBJECT_ID('dbo.RouteLocations', 'U')           IS NOT NULL DROP TABLE dbo.RouteLocations;
IF OBJECT_ID('dbo.TimeSlots', 'U')                IS NOT NULL DROP TABLE dbo.TimeSlots;
IF OBJECT_ID('dbo.Routes', 'U')                   IS NOT NULL DROP TABLE dbo.Routes;
IF OBJECT_ID('dbo.DriverProfiles', 'U')           IS NOT NULL DROP TABLE dbo.DriverProfiles;
IF OBJECT_ID('dbo.StudentProfiles', 'U')          IS NOT NULL DROP TABLE dbo.StudentProfiles;
IF OBJECT_ID('dbo.Users', 'U')                    IS NOT NULL DROP TABLE dbo.Users;
GO

/* =====================================================================
   TABLES
   ===================================================================== */

CREATE TABLE dbo.Users (
    Id        INT IDENTITY(1,1) CONSTRAINT PK_Users PRIMARY KEY,
    Name      NVARCHAR(100) NOT NULL,
    Username  NVARCHAR(50)  NOT NULL CONSTRAINT UQ_Users_Username UNIQUE,
    [Password] NVARCHAR(100) NOT NULL,
    [Role]    NVARCHAR(20)  NOT NULL,      -- Admin / Driver / Student
    [Status]  NVARCHAR(20)  NOT NULL CONSTRAINT DF_Users_Status DEFAULT 'Active'  -- Active / Blocked ...
);

CREATE TABLE dbo.StudentProfiles (
    UserId     INT           NOT NULL CONSTRAINT PK_StudentProfiles PRIMARY KEY,
    StudentId  NVARCHAR(20)  NOT NULL CONSTRAINT UQ_StudentProfiles_StudentId UNIQUE,
    Department NVARCHAR(100) NOT NULL,
    Email      NVARCHAR(100) NOT NULL,
    CONSTRAINT FK_StudentProfiles_Users FOREIGN KEY (UserId)
        REFERENCES dbo.Users(Id) ON DELETE CASCADE
);

CREATE TABLE dbo.DriverProfiles (
    UserId    INT          NOT NULL CONSTRAINT PK_DriverProfiles PRIMARY KEY,
    LicenseNo NVARCHAR(50) NOT NULL,
    Phone     NVARCHAR(20) NOT NULL,
    CONSTRAINT FK_DriverProfiles_Users FOREIGN KEY (UserId)
        REFERENCES dbo.Users(Id) ON DELETE CASCADE
);

CREATE TABLE dbo.Routes (
    Id        INT IDENTITY(1,1) CONSTRAINT PK_Routes PRIMARY KEY,
    RouteName NVARCHAR(100) NOT NULL,
    Direction NVARCHAR(50)  NOT NULL       -- e.g. To Campus / From Campus
);

CREATE TABLE dbo.RouteLocations (
    Id           INT IDENTITY(1,1) CONSTRAINT PK_RouteLocations PRIMARY KEY,
    RouteId      INT           NOT NULL,
    LocationName NVARCHAR(100) NOT NULL,
    CONSTRAINT FK_RouteLocations_Routes FOREIGN KEY (RouteId)
        REFERENCES dbo.Routes(Id) ON DELETE CASCADE
);

CREATE TABLE dbo.TimeSlots (
    Id        INT IDENTITY(1,1) CONSTRAINT PK_TimeSlots PRIMARY KEY,
    StartTime TIME NOT NULL,
    EndTime   TIME NOT NULL
);

CREATE TABLE dbo.BusAssignments (
    Id         INT IDENTITY(1,1) CONSTRAINT PK_BusAssignments PRIMARY KEY,
    RouteId    INT  NOT NULL,
    DriverId   INT  NOT NULL,              -- Users.Id of the driver
    TimeSlotId INT  NOT NULL,
    [Date]     DATE NOT NULL,
    CONSTRAINT FK_BusAssignments_Routes    FOREIGN KEY (RouteId)    REFERENCES dbo.Routes(Id),
    CONSTRAINT FK_BusAssignments_Drivers   FOREIGN KEY (DriverId)   REFERENCES dbo.Users(Id),
    CONSTRAINT FK_BusAssignments_TimeSlots FOREIGN KEY (TimeSlotId) REFERENCES dbo.TimeSlots(Id)
);

CREATE TABLE dbo.StudentPickupSelections (
    Id         INT IDENTITY(1,1) CONSTRAINT PK_StudentPickupSelections PRIMARY KEY,
    StudentId  INT NOT NULL,               -- Users.Id of the student
    LocationId INT NOT NULL,               -- RouteLocations.Id
    TimeSlotId INT NOT NULL,
    CONSTRAINT FK_Pickup_Students   FOREIGN KEY (StudentId)  REFERENCES dbo.Users(Id) ON DELETE CASCADE,
    CONSTRAINT FK_Pickup_Locations  FOREIGN KEY (LocationId) REFERENCES dbo.RouteLocations(Id),
    CONSTRAINT FK_Pickup_TimeSlots  FOREIGN KEY (TimeSlotId) REFERENCES dbo.TimeSlots(Id)
);

CREATE TABLE dbo.TravelLogs (
    Id              INT IDENTITY(1,1) CONSTRAINT PK_TravelLogs PRIMARY KEY,
    StudentId       INT           NOT NULL,   -- Users.Id of the student
    AssignmentId    INT           NULL,       -- NULL allowed: the app inserts NULL on quick pickup confirm
    Amount          DECIMAL(10,2) NOT NULL CONSTRAINT DF_TravelLogs_Amount DEFAULT 10,
    IsPaid          BIT           NOT NULL CONSTRAINT DF_TravelLogs_IsPaid DEFAULT 0,
    PickupConfirmed BIT           NOT NULL CONSTRAINT DF_TravelLogs_Pickup DEFAULT 0,
    [Date]          DATE          NOT NULL,
    CONSTRAINT FK_TravelLogs_Students    FOREIGN KEY (StudentId)    REFERENCES dbo.Users(Id) ON DELETE CASCADE,
    CONSTRAINT FK_TravelLogs_Assignments FOREIGN KEY (AssignmentId) REFERENCES dbo.BusAssignments(Id)
);
GO

/* =====================================================================
   DUMMY DATA
   (Run on freshly created tables so the identity IDs below match.)
   ===================================================================== */

-- Users: 1 admin, 3 drivers (Ids 2-4), 5 students (Ids 5-9)
INSERT INTO dbo.Users (Name, Username, [Password], [Role], [Status]) VALUES
('System Admin',      'admin',   'admin123',   'Admin',   'Active'),
('Rahim Uddin',       'rahim',   'driver123',  'Driver',  'Active'),
('Karim Hossain',     'karim',   'driver123',  'Driver',  'Active'),
('Jamal Mia',         'jamal',   'driver123',  'Driver',  'Active'),
('Nusrat Jahan',      'nusrat',  'student123', 'Student', 'Active'),
('Tanvir Ahmed',      'tanvir',  'student123', 'Student', 'Active'),
('Farhana Akter',     'farhana', 'student123', 'Student', 'Active'),
('Sakib Rahman',      'sakib',   'student123', 'Student', 'Active'),
('Mehjabin Chowdhury','mehjabin','student123', 'Student', 'Blocked');

INSERT INTO dbo.DriverProfiles (UserId, LicenseNo, Phone) VALUES
(2, 'DL-100201', '01711000001'),
(3, 'DL-100202', '01711000002'),
(4, 'DL-100203', '01711000003');

INSERT INTO dbo.StudentProfiles (UserId, StudentId, Department, Email) VALUES
(5, '22-46001-1', 'Computer Science',      'nusrat@student.aiub.edu'),
(6, '22-46002-1', 'Software Engineering',  'tanvir@student.aiub.edu'),
(7, '23-47003-2', 'EEE',                   'farhana@student.aiub.edu'),
(8, '23-47004-2', 'BBA',                   'sakib@student.aiub.edu'),
(9, '24-48005-3', 'Computer Engineering',  'mehjabin@student.aiub.edu');

-- Routes (Ids 1-3)
INSERT INTO dbo.Routes (RouteName, Direction) VALUES
('Uttara - AIUB',    'To Campus'),
('Mirpur - AIUB',    'To Campus'),
('Dhanmondi - AIUB', 'To Campus');

-- Route locations (Ids 1-10)
INSERT INTO dbo.RouteLocations (RouteId, LocationName) VALUES
(1, 'Uttara Sector 10'),   -- 1
(1, 'Uttara Sector 7'),    -- 2
(1, 'Airport'),            -- 3
(1, 'Kuril'),              -- 4
(2, 'Mirpur 10'),          -- 5
(2, 'Mirpur 1'),           -- 6
(2, 'Kazipara'),           -- 7
(3, 'Dhanmondi 27'),       -- 8
(3, 'Farmgate'),           -- 9
(3, 'Banani');             -- 10

-- Time slots (Ids 1-4)
INSERT INTO dbo.TimeSlots (StartTime, EndTime) VALUES
('07:00', '08:00'),
('09:00', '10:00'),
('14:00', '15:00'),
('17:00', '18:00');

-- Bus assignments (Ids 1-6): dates are relative to today so the app always has data to show
INSERT INTO dbo.BusAssignments (RouteId, DriverId, TimeSlotId, [Date]) VALUES
(1, 2, 1, CAST(GETDATE() AS DATE)),                    -- 1 today
(2, 3, 1, CAST(GETDATE() AS DATE)),                    -- 2 today
(3, 4, 2, CAST(GETDATE() AS DATE)),                    -- 3 today
(1, 2, 3, CAST(DATEADD(DAY, 1, GETDATE()) AS DATE)),   -- 4 tomorrow
(2, 3, 4, CAST(DATEADD(DAY, 1, GETDATE()) AS DATE)),   -- 5 tomorrow
(1, 2, 1, CAST(DATEADD(DAY, -1, GETDATE()) AS DATE));  -- 6 yesterday

-- Student pickup selections
INSERT INTO dbo.StudentPickupSelections (StudentId, LocationId, TimeSlotId) VALUES
(5, 1, 1),   -- Nusrat  : Uttara Sector 10, 07:00
(6, 2, 1),   -- Tanvir  : Uttara Sector 7,  07:00
(7, 5, 1),   -- Farhana : Mirpur 10,        07:00
(8, 8, 2);   -- Sakib   : Dhanmondi 27,     09:00

-- Travel logs
INSERT INTO dbo.TravelLogs (StudentId, AssignmentId, Amount, IsPaid, PickupConfirmed, [Date]) VALUES
(5, 6, 10, 1, 1, CAST(DATEADD(DAY, -1, GETDATE()) AS DATE)),  -- paid, yesterday
(6, 6, 10, 0, 1, CAST(DATEADD(DAY, -1, GETDATE()) AS DATE)),  -- due,  yesterday
(5, 1, 10, 0, 1, CAST(GETDATE() AS DATE)),                    -- due,  today, picked up
(7, 2, 10, 0, 0, CAST(GETDATE() AS DATE));                    -- due,  today, not picked up
GO

/* =====================================================================
   QUICK CHECKS (run these for your screenshots)
   ===================================================================== */
SELECT 'Users' AS TableName, COUNT(*) AS Total FROM dbo.Users
UNION ALL SELECT 'StudentProfiles', COUNT(*) FROM dbo.StudentProfiles
UNION ALL SELECT 'DriverProfiles', COUNT(*) FROM dbo.DriverProfiles
UNION ALL SELECT 'Routes', COUNT(*) FROM dbo.Routes
UNION ALL SELECT 'RouteLocations', COUNT(*) FROM dbo.RouteLocations
UNION ALL SELECT 'TimeSlots', COUNT(*) FROM dbo.TimeSlots
UNION ALL SELECT 'BusAssignments', COUNT(*) FROM dbo.BusAssignments
UNION ALL SELECT 'StudentPickupSelections', COUNT(*) FROM dbo.StudentPickupSelections
UNION ALL SELECT 'TravelLogs', COUNT(*) FROM dbo.TravelLogs;
GO
