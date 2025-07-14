using Simple_Inventory_Management_System.logic;

// Sample Test for Editing, Deleting, Searching and Viewing Products...

void PrintProducts(InventoryOperations ops)
{
    var list = ops.ViewProducts();

    foreach (string message in list)
    {
        Console.WriteLine(message);
    }
}

Console.WriteLine("Hello Simple Inventory Management System");

var ops = new InventoryOperations();

ops.AddProduct("Milk", 15.5, 3);
ops.AddProduct("Rice", 20, 5);

PrintProducts(ops);

ops.EditProduct(ops.ProductExists("Milk"), "Milk1", 15.5, 3);
ops.DeleteProduct(ops.ProductExists("Rice"));

PrintProducts(ops);

Console.WriteLine(ops.SearchProduct(ops.ProductExists("Milk1")));