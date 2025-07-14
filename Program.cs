using Simple_Inventory_Management_System.logic;

// Sample Test for Editing and Viewing Products...

Console.WriteLine("Hello Simple Inventory Management System");

var ops = new InventoryOperations();

ops.AddProduct("Milk",15.5,3);
ops.AddProduct("Rice",20,5);

var list = ops.ViewProducts();

foreach (string message in list)
{
    Console.WriteLine(message);
}

ops.EditProduct(ops.ProductExists("Milk"),"Milk1",15.5,3);