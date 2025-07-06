# Lab 6: Updating and Deleting Records 
## Scenario: 
The store updates product prices and removes discontinued items. 
## Objective: 
Update and delete records using EF Core. 
## Steps: 
### 1. Update a Product: 
```
var product = await context.Products.FirstOrDefaultAsync(p => p.Name == "Lapt
 op"); 
if (product != null) { 
product.Price = 70000; 
await context.SaveChangesAsync(); 
}
```
### 2. Delete a Product: 
```
var toDelete = await context.Products.FirstOrDefaultAsync(p => p.Name == "Rice
 Bag"); 
if (toDelete != null) { 
context.Products.Remove(toDelete); 
await context.SaveChangesAsync(); 
}
```
