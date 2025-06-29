CREATE DATABASE CUSTOMERS_SALES_DATA;
GO

USE CUSTOMERS_SALES_DATA;
GO

-- Create Customers Table
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    Name VARCHAR(100),
    Region VARCHAR(50)
);

-- Create Products Table
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10, 2)
);

-- Create Orders Table
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

-- Create OrderDetails Table
CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

-- Insert Data into Customers
INSERT INTO Customers (CustomerID, Name, Region) VALUES
(1, 'Alice', 'North'),
(2, 'Bob', 'South'),
(3, 'Charlie', 'East'),
(4, 'David', 'West');

-- Insert Data into Products
INSERT INTO Products (ProductID, ProductName, Category, Price) VALUES
(1, 'Laptop', 'Electronics', 1200.00),
(2, 'Smartphone', 'Electronics', 800.00),
(3, 'Tablet', 'Electronics', 600.00),
(4, 'Headphones', 'Accessories', 150.00);

-- Insert Data into Orders
INSERT INTO Orders (OrderID, CustomerID, OrderDate) VALUES
(1, 1, '2023-01-15'),
(2, 2, '2023-02-20'),
(3, 3, '2023-03-25'),
(4, 4, '2023-04-30');

-- Insert Data into OrderDetails
INSERT INTO OrderDetails (OrderDetailID, OrderID, ProductID, Quantity) VALUES
(1, 1, 1, 1),
(2, 2, 2, 2),
(3, 3, 3, 1),
(4, 4, 4, 3);

SELECT
    Category,
    ProductName,
    Price,
    ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
FROM Products;

SELECT
    Category,
    ProductName,
    Price,
    RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS PriceRank
FROM Products;

SELECT
    Category,
    ProductName,
    Price,
    DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRank
FROM Products;

--BEFORE INDEXING 
SELECT * FROM Products WHERE ProductName = 'Laptop';

-- NonClustered Indexing
CREATE NONCLUSTERED INDEX idx_ProductName ON Products(ProductName);

--Clustered Indexing
CREATE CLUSTERED INDEX idx_ProductPrice ON Products(Price);

--CompositeIndexing
CREATE NONCLUSTERED INDEX idx_CustomerOrderDate ON Orders(CustomerID, OrderDate);

SELECT * FROM Orders WHERE CustomerID = 1 AND OrderDate = '2023-01-15';