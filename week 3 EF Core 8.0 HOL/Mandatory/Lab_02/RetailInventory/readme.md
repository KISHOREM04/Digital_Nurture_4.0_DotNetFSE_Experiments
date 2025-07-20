# Lab 2: Setting Up the Database Context for a Retail Store 
## Scenario: 
The retail store wants to store product and category data in SQL Server. 
## Objective: 
Configure DbContext and connect to SQL Server. 
## Steps: 
### 1. Create Models: 
```
public class Category { 
public int Id { get; set; } 
public string Name { get; set; } 
public List Products { get; set; } 
} 
public class Product { 
public int Id { get; set; } 
public string Name { get; set; } 
public decimal Price { get; set; } 
public int CategoryId { get; set; } 
public Category Category { get; set; } 
}
```
### 2. Create AppDbContext: 
```
public class AppDbContext : DbContext { 
public DbSet Products { get; set; } 
public DbSet Categories { get; set; } 
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuild
 er) { 
optionsBuilder.UseSqlServer("Your_Connection_String_Here"); 
} 
}
```
### 3. Add Connection String in appsettings.json (optional for ASP.NET Core).
