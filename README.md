# AIUB Bus Management System

Database course project (AIUB). A .NET desktop application with a SQL Server (LocalDB) database.

## Source and credits
Original project by **morsalin1310**: https://github.com/morsalin1310/AiubBusManagementSystem
All credit for the original application code goes to the original author.
The database script (`AiubBusDB.sql`) was prepared with AI assistance (Claude by Anthropic),
based on the SQL queries in the project's source code.

## What the system does
- **Admin:** manages users, routes and bus assignments, views reports and total fees collected
- **Driver:** sees assigned routes, students waiting at each stop, and confirms pickups
- **Student:** chooses a pickup stop and time slot, views due travel fees

## Database setup
1. Install .NET, SQL Server (LocalDB or Express) and SQL Server Management Studio (SSMS).
2. Open SSMS and connect to `(localdb)\MSSQLLocalDB` with Windows Authentication.
3. Open `AiubBusDB.sql`, select no database (the script creates `AiubBusDB`), and press **F5**.
4. In `Utils/DbConnection.cs`, set the connection string to:
   ```
   Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AiubBusDB;Integrated Security=True;TrustServerCertificate=True
   ```
5. Open the solution in Visual Studio, build and run.

## Database tables
`Users`, `StudentProfiles`, `DriverProfiles`, `Routes`, `RouteLocations`, `TimeSlots`,
`BusAssignments`, `StudentPickupSelections`, `TravelLogs`

## Demo accounts
| Role | Username | Password |
|---|---|---|
| Admin | admin | admin123 |
| Driver | rahim, karim, jamal | driver123 |
| Student | nusrat, tanvir, farhana, sakib | student123 |
| Student (blocked) | mehjabin | student123 |

## Demonstration video
https://drive.google.com/file/d/1ZjAM9ePMnUDVCcyKNUObUDu0e5MgOqqg/view?usp=sharing

## Prepared by
Tasnim Hasan Adib, AIUB
