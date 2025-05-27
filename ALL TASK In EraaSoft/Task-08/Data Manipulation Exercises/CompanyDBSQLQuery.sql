--1.	Create a new database named "CompanyDB."
Create DataBase CompanyDB ;
go 
Use CompanyDB;
go 
--2.	Create a schema named "Sales" within the "CompanyDB" database.
Create Schema Sales;
go 
--3.	Create a table named "employees" with columns: employee_id (INT), first_name (VARCHAR), last_name (VARCHAR), and salary (DECIMAL) within the "Sales" schema.
--Note: on employee_id use sequence instead of identity.
CREATE SEQUENCE EmpIdSequ
    AS INT
    START WITH 1
    INCREMENT BY 1 ;

CREATE TABLE Sales.Employees (
	EmployeeID INT PRIMARY KEY DEFAULT(NEXT VALUE FOR EmpIdSequ),
	FirstName  VARCHAR(50),
	LastName  VARCHAR(50),
	Salary DECIMAL,
)
--4.	Alter the "employees" table to add a new column named "hire_date" with the data type DATE.
Alter Table Sales.Employees 
Add HireDate Date;

--5.	Add mock data to this table use https://www.mockaroo.comDATA MANIPULATION Exercises:
-- The solution is in the file Sales.Employees.sql.

-- DATA MANIPULATION Exercises:

-- 1.	Select all columns from the "employees" table.
Select * From Sales.Employees ;

--2.	Retrieve only the "first_name" and "last_name" columns from the "employees" table.
Select FirstName, LastName From Sales.Employees ;

--3.	Retrieve “full name” as a one column from "first_name" and "last_name" columns from the "employees" table.
Select FirstName + '  ' + LastName FullName  
from Sales.Employees;

--4.	Show the average salary of all employees. (search on it)
Select TotalEmployee = Count(Salary) ,
AverageSalary = Avg(Salary) 
from Sales.Employees;

--5.	Select employees whose salary is greater than 5000.
-- When I created the data I made the salary between 3000 and 12000, so I made the query at 5000.
Select * 
From Sales.Employees
Where Salary < 5000;

--6.	Retrieve employees hired in the year 2020.
Select *
From Sales.Employees
Where HireDate between '2020/01/01' And '2020/12/31'
Order by HireDate;

Select *
From Sales.Employees
Where Year(HireDate) = 2020
Order by HireDate;

--7.	List employees whose last names start with 'S.'
Select * 
From Sales.Employees
where LastName Like 'S%'
Order By FirstName;

--8.	Display the top 10 highest-paid employees.
Select top 10 * 
From Sales.Employees
order by Salary desc;

--9.	Find employees with salaries between 4000 and 6000.
-- When I created the data I made the salary between 3000 and 12000, so I made the query at 5000.
Select * 
From Sales.Employees
Where Salary >= 4000 And Salary <=6000
order by Salary; 

--10.	Show employees with names containing the substring 'man.'
Select *
From Sales.Employees
Where FirstName +'  '+LastName Like '%man%';

Select *
From Sales.Employees
Where FirstName Like '%man%' OR LastName Like '%man%';

--11.	Display employees with a NULL value in the "hire_date" column.
insert into Sales.Employees (EmployeeID, FirstName, LastName, Salary) values (1001, 'Ahmed', 'Hassan', 10646);
insert into Sales.Employees (EmployeeID, FirstName, LastName, Salary) values (1002, 'Hossam', 'Hassan', 7307);
insert into Sales.Employees (EmployeeID, FirstName, LastName, Salary) values (1003, 'Abdelwahab', 'Shandy', 50000);
insert into Sales.Employees (EmployeeID, FirstName, LastName, Salary) values (1004, 'Anas', 'Shandy', 70000);
--I added some colons that contain new HireDate equal to null so that I can get the correct result for this question.
Select *
From Sales.Employees
Where HireDate  IS Null ;

--12.	Select employees with a salary in the set (4000, 4500, 5000)
-- When I created the data I made the salary between 3000 and 12000, so I made the query at 4000,4500,5000.
Select *
From Sales.Employees
Where Salary Between 4000  and 5000 ;

--13.	Retrieve employees hired between '2020-01-01' and '2021-01-01.'
Select *
From Sales.Employees
Where HireDate between  '2020-01-01' And '2021-01-01'
Order by HireDate;

--14.	List employees with salaries in descending order.
Select *
From Sales.Employees
Where Salary IS Not Null 
Order By Salary desc ;

--15.	Show the first 5 employees ordered by "last_name" in ascending order.
Select * 
From Sales.Employees
Order By LastName;

--16.	Display employees with a salary greater than 55000 and hired in 2020.
-- When I created the data I made the salary between 3000 and 12000, so I made the query at 5500.
Select * From Sales.Employees
Where Salary > 5500 And  Year(HireDate) = 2020 ;  

--17.	Select employees whose first name is 'John' or 'Jane.'
Select * From Sales.Employees
Where FirstName = 'John' Or FirstName = 'Jane' ;

SELECT * FROM Sales.Employees
WHERE FirstName IN ('John', 'Jane');

--18.	List employees with a salary less than or equal to 5500 and a hire date after '2022-01-01.'
-- When I created the data I made the salary between 3000 and 12000, so I made the query at 5500.
Select * From Sales.Employees
Where Salary <= 5500 And  HireDate > '2022-01-01'
order By HireDate;

-- Resorce a Case in https://www.w3schools.com/sql/func_sqlserver_cast.asp And Search ;
--CAST(expression AS DataType)
Select * From Sales.Employees
Where Salary <= 5500 
And  
HireDate Between '2022-01-01' And Cast (GETDATE() As Date);

--19.	Retrieve employees with a salary greater than the average salary.

Select * From Sales.Employees
Where Salary > (Select AVG(Salary) From Sales.Employees);

-- ASK Eng
DECLARE @AvgSalary DECIMAL;
SELECT @AvgSalary = AVG(Salary) FROM Sales.Employees;
SELECT *
FROM Sales.Employees
WHERE Salary > @AvgSalary;

-- Ask Eng
With AverageSalary   As(
	select AVG(Salary) AS AvgSalary From Sales.Employees
)
Select * From Sales.Employees 
Where Salary > (Select AvgSalary From AverageSalary );



--20.	Display the 3rd to 7th highest-paid employees.
Select * From Sales.Employees
Order By Salary desc
Offset 2 Rows
Fetch Next 7 Rows Only;

--21.	List employees hired after '2021-01-01' in alphabetical order.
Select * From Sales.Employees 
Where HireDate > '2021-01-01' 
order by FirstName , LastName;

--22.	Retrieve employees with a salary greater than 5000 and last name not starting with 'A.'
Select * From Sales.Employees
Where Salary > 5000 And LastName !='A%';

--23.	Display employees with a salary that is not NULL.
insert into Sales.Employees (EmployeeID, FirstName, LastName) values (1005, 'Ahmed', 'Hassan');
insert into Sales.Employees (EmployeeID, FirstName, LastName) values (1006, 'Hossam', 'Hassan');
insert into Sales.Employees (EmployeeID, FirstName, LastName) values (1007, 'Abdelwahab', 'Shandy');
insert into Sales.Employees (EmployeeID, FirstName, LastName) values (1008, 'Anas', 'Shandy');
--I added some colons that contain new HireDate equal to null so that I can get the correct result for this question.
Select * From Sales.Employees
Where Salary Is NOT Null;

--24.	Show employees with names containing 'e' or 'i' and a salary greater than 4500.
Select * From Sales.Employees 
Where Salary > 4500 
And 
FirstName + LastName LIKE '%e%' 
And 
FirstName + LastName LIKE '%i%';
