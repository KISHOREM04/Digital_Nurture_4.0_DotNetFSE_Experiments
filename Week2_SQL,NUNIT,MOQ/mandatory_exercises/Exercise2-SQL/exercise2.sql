CREATE PROCEDURE sp_InsertEmployee 
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10, 2),
    @JoinDate DATE
AS BEGIN
    INSERT INTO Employees
        (FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES (@FirstName, @LastName, @DepartmentID, @Salary, @JoinDate);
END;
GO
EXEC sp_InsertEmployee 
    @FirstName = 'Rony',
    @LastName = 'Gasper',
    @DepartmentID = 2,
    @Salary = 55000.00,
    @JoinDate = '2023-06-01';
GO
SELECT * FROM Employees WHERE FirstName = 'Rony' AND LastName = 'Gasper';
