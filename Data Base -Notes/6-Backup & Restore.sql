-- You should visit this link, where you will find many simple and large application projects on the database.
-- https://github.com/abdelwahab-ahmed-shandy/Database-Design-with-ERD-EERD-Relational-Schemas-SQL-Implementation

--Created By Abdelwahab Shandy
--Don't Forget To Pray For Me And My Parents
--Backup & Restore Database

-- SQL BACKUP DATABASE Statement : 
BACKUP DATABASE MyDatabase1
TO DISK = 'C:\MyDatabase1_backup.bak';

-- SQL DIFFERENTIAL BACKUP DATABASE Statement
BACKUP DATABASE MyDatabase1
TO DISK = 'C:\MyDatabase1_backup.bak'
WITH DIFFERENTIAL;

-- Restore Database From Backup
RESTORE DATABASE MyDatabase1
FROM DISK = 'C:\MyDatabase1.bak';
