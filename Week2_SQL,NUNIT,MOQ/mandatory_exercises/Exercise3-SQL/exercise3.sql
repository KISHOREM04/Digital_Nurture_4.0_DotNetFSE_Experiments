CREATE PROCEDURE sp_GetEmployeeCountByDept @DeptID INT
AS
BEGIN
    SELECT COUNT(*) AS EmployeeCount
    FROM Employees
    WHERE DepartmentID = @DeptID
END;
GO
EXEC sp_GetEmployeeCountByDept @DeptID = 1;