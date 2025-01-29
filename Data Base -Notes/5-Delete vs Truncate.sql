-- You should visit this link, where you will find many simple and large application projects on the database.
-- https://github.com/abdelwahab-ahmed-shandy/Database-Design-with-ERD-EERD-Relational-Schemas-SQL-Implementation

--Created By Abdelwahab Shandy
--Don't Forget To Pray For Me And My Parents
--Delete vs Truncate statement

USE DB1;
Select * From Departments;

insert into Departments
values 
('IT'),
('HR');
--Check with
Print @@identity;

-- This will delete all rows but not reset the identity counter :
Delete from Departments;

-- This will delete all rows and rest the identity counter:
Truncate table Departments;






