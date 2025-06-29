CREATE DATABASE EmployeeManagement;
GO

USE EmployeeManagement;

-- departmentsTable
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);

-- employeesTable
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT FOREIGN KEY REFERENCES Departments(DepartmentID),
    Salary DECIMAL(10,2),
    JoinDate DATE
);

-- Insert Departments (unchanged)
INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'HR'),
(2, 'Finance'),
(3, 'IT'),
(4, 'Marketing');

-- Insert Employees (Indian Names + More Data)
INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate) VALUES
('John', 'Doe', 1, 5000.00, '2020-01-15'),
('Jane', 'Smith', 2, 6000.00, '2019-03-22'),
('Michael', 'Johnson', 3, 7000.00, '2018-07-30'),
('Emily', 'Davis', 4, 5500.00, '2021-11-05'),
('Rahul', 'Sharma', 1, 5200.00, '2022-01-10'),
('Priya', 'Agarwal', 2, 6100.00, '2022-06-18'),
('Amit', 'Verma', 3, 7300.00, '2022-02-01'),
('Neha', 'Patel', 4, 5400.00, '2021-09-20'),
('Vikram', 'Singh', 3, 7100.00, '2023-01-05'),
('Kavita', 'Rao', 1, 4900.00, '2023-02-14'),
('Anil', 'Mehta', 2, 6300.00, '2020-12-30'),
('Sneha', 'Kumar', 3, 7500.00, '2024-03-12'),
('Rohan', 'Gupta', 4, 5800.00, '2024-04-10');

--creating a procedure
CREATE PROCEDURE sp_InsertEmployee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE
AS
BEGIN
    INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES (@FirstName, @LastName, @DepartmentID, @Salary, @JoinDate);
END;

EXEC sp_InsertEmployee 'Dipanjan', 'Saha', 3, 6200.00, '2022-02-01';

--return value from procedure
CREATE PROCEDURE sp_GetEmployeeCountByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;

EXEC sp_GetEmployeeCountByDepartment @DepartmentID = 3;


CREATE FUNCTION fn_GetEmployeeCountByDept (@DeptID INT)
RETURNS INT
AS
BEGIN
    DECLARE @Count INT;
    SELECT @Count = COUNT(*) 
    FROM Employees 
    WHERE DepartmentID = @DeptID;
    RETURN @Count;
END;

SELECT dbo.fn_GetEmployeeCountByDept(3) AS TotalEmployees;

CREATE FUNCTION fn_CalculateAnnualSalary (@MonthlySalary DECIMAL(10,2))
RETURNS DECIMAL(12,2)
AS
BEGIN
    RETURN (@MonthlySalary * 12);
END;

SELECT 
    EmployeeID,
    FirstName,
    LastName,
    Salary AS MonthlySalary,
    dbo.fn_CalculateAnnualSalary(Salary) AS AnnualSalary
FROM Employees;

SELECT 
    FirstName,
    LastName,
    Salary AS MonthlySalary,
    dbo.fn_CalculateAnnualSalary(Salary) AS AnnualSalary
FROM Employees
WHERE EmployeeID = 5;