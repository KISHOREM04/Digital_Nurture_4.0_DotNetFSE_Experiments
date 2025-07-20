# Lab 4: Inserting Initial Data into the Database 
## Scenario: 
The store manager wants to add initial product categories and products to the system. 
## Objective: 
Use EF Core to insert records using AddAsync and SaveChangesAsync. 
## Steps: 
### 1. Insert Data in Program.cs: 
```
using var context = new AppDbContext(); 
var electronics = new Category { Name = "Electronics" }; 
var groceries = new Category { Name = "Groceries" }; 
await context.Categories.AddRangeAsync(electronics, groceries); 
var product1 = new Product { Name = "Laptop", Price = 75000, Category = electro
 nics }; 
var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceri
 es }; 
await context.Products.AddRangeAsync(product1, product2); 
await context.SaveChangesAsync();
```
### 2. Run the App: 
```
dotnet run
```
### 3. Verify in SQL Server: 
Check that the data is inserted correctly.
