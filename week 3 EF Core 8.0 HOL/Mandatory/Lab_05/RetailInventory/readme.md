# Lab 5: Retrieving Data from the Database 
## Scenario: 
The store wants to display product details on the dashboard. 
## Objective: 
Use Find, FirstOrDefault, and ToListAsync to retrieve data. 
## Steps: 
### 1. Retrieve All Products: 
```
var products = await context.Products.ToListAsync(); 
foreach (var p in products) 
Console.WriteLine($"{p.Name} - ₹{p.Price}");
```
### 2. Find by ID: 
```
var product = await context.Products.FindAsync(1); 
Console.WriteLine($"Found: {product?.Name}");
```
### 3. FirstOrDefault with Condition: 
```
var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000); 
Console.WriteLine($"Expensive: {expensive?.Name}");
```
