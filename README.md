# Simple Inventory Management System

A console-based application that allows users to manage an inventory of products with basic CRUD operations. Each product has a name, price, and quantity, and the system supports searching and editing of products as well. This project is built with C# and is designed to demonstrate object-oriented programming principles and Git version control.


## Features
### Add a Product
Prompt user for product details (name, price, quantity) and add it to the inventory. 

### View All Products
Display a list of all products, including their names, prices, and quantities.

### Edit a Product
Find a product by name and update its attributes.

### Delete a Product
Remove a product from the inventory by its name.

### Search for a Product
Search for a product and display its information if found.

### Exit the Application
Cleanly exits the program.

## Project Structure
Simple-Inventory-Management-System/

```
Simple-Inventory-Management-System/
│
├── models/
│   ├── enums/
│   │   └── Choice.cs
│   ├── interfaces/
│   │   └── InventoryCRUD.cs
│   ├── Inventory.cs
│   └── Product.cs     
│
├── logic/
│   └── InventoryOperations.cs     
│
├── Program.cs            
│
└── README.md         
```