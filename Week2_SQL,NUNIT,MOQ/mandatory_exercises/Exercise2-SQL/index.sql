CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10, 2),
    JoinDate DATE,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'Human Resources'),
(2, 'Engineering'),
(3, 'Sales'),
(4, 'Marketing');

INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate) VALUES
(101, 'Alice', 'Johnson', 1, 50000.00, '2020-01-10'),
(102, 'Bob', 'Smith', 2, 75000.00, '2019-03-15'),
(103, 'Charlie', 'Brown', 2, 80000.00, '2021-07-20'),
(104, 'David', 'Lee', 3, 60000.00, '2018-05-30'),
(105, 'Eve', 'Williams', 4, 65000.00, '2022-11-01');