-- Data Definition Questions
Create DataBase Task_7;

use Task_7;

-- 1. Create a table named "Employees" with columns for ID (integer),Name (varchar), and Salary (decimal).

Create Table Employees (
	EmployeeID INT identity(1,1) Primary Key ,
	Name varchar ,
	Salary decimal 
);

-- 2. Add a new column named "Department" to the "Employees" table with data type varchar(50).

Alter Table Employees 
Add Department varchar(50) ;

-- 3. Remove the "Salary" column from the "Employees" table.

Alter Table Employees
Drop Column Salary ;

-- 4. Rename the "Department" column in the "Employees" table to "DeptName".

exec sp_rename 'Employees.Department' , 'DeptName' , 'Column';

-- 5. Create a new table called "Projects" with columns for ProjectID (integer) and ProjectName (varchar).

Create table Projects(
	ProjectID Int Primary Key identity(1,1) ,
	ProjectName varchar 
);

-- 6. Add a primary key constraint to the "Employees" table for the "ID" column.

-- Because I had added the EmployeeID and primarykey before,
-- I removed the primarykey by design, then I implemented this part....

Alter Table Employees
ADD Constraint IDEmployee Primary Key (EmployeeID);

--7. Add a unique constraint to the "Name" column in the "Employees" table.

Alter Table Employees 
Add Constraint UniqueThisName unique (Name);

-- 8. Create a table named "Customers" with columns for CustomerID (integer), FirstName (varchar), LastName (varchar), and Email (varchar), and Status (varchar).

Create Table Customers(
	CustomerID  INT IDENTITY(1,1) Primary key ,
	FirstName varchar,
	LastName  varchar,
	Email varchar,
	Status varchar
);

-- 9. Add a unique constraint to the combination of "FirstName" and "LastName" columns in the "Customers" table.
Alter table Customers
Add constraint UniqueFName unique (FirstName) ;

Alter table Customers
Add constraint UniqueLName unique (LastName) ;

-- 10. Create a table named "Orders" with columns for OrderID (integer), CustomerID (integer), OrderDate (datetime), and TotalAmount (decimal).

Create table Orders(
	OrderID int primary key ,
	CustomerID int ,
	OrderDate datetime2 ,
	TotalAmount decimal
);

-- 11. Add a check constraint to the "TotalAmount" column in the "Orders" table to ensure that it is greater than zero.

Alter table Orders
Add constraint TotalAmountGreaterThanZero check (TotalAmount > 0);

-- 12. Create a schema named "Sales" and move the "Orders" table into this schema.

Create schema Sales ;

ALter schema Sales Transfer dbo.Orders ;

-- 13.	Rename the "Orders" table to "SalesOrders."

exec sp_rename 'Sales.Orders' , 'SalesOrders' ;

-- Done Task 
-- Abdelwahab Shandy 