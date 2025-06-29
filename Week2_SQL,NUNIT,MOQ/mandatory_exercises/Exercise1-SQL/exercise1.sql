/* Row_NUMBER() */
SELECT * FROM (
    SELECT 
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price) AS RowNum
    FROM Products
) AS RankedProducts
WHERE RowNum <= 3;

/* RANK() */
SELECT * FROM (
    SELECT 
        ProductID,
        ProductName,
        Category,
        Price,
        RANK() OVER (PARTITION BY Category ORDER BY Price) AS RowNum
    FROM Products
) AS Ranked
WHERE RowNum <= 3;

/* DENSE_RANK() */
SELECT * FROM (
    SELECT 
        ProductID,
        ProductName,
        Category,
        Price,
        DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price) AS RowNum
    FROM Products
) AS RankedProd
WHERE RowNum <= 3;