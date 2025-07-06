# Lab 7: Writing Queries with LINQ 
## Scenario: 
The store wants to filter and sort products for reporting. 
## Objective: 
Use Where, Select, OrderBy, and project into DTOs. 
## Steps: 
### 1. Filter and Sort: 
```
var filtered = await context.Products 
.Where(p => p.Price > 1000) 
.OrderByDescending(p => p.Price) 
.ToListAsync(); 
```
### 2. Project into DTO: 
```
var productDTOs = await context.Products 
.Select(p => new { p.Name, p.Price }) 
.ToListAsync();
```
