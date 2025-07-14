using Simple_Inventory_Management_System.logic;
using Simple_Inventory_Management_System.models;
using Simple_Inventory_Management_System.models.enums;


Choice choice = Choice.NONE;
var ops = new InventoryOperations();

do
{
    PrintWelcome();
    try
    {
        choice = (Choice)Int32.Parse(Console.ReadLine());
        switch (choice)
        {
            case Choice.ADD:
                AddChoice();
                break;
            case Choice.VIEWALL:
                ViewAllChoice();
                break;
            case Choice.EDIT:
                // do edit
                break;
            case Choice.DELETE:
                // do delete
                break;
            case Choice.SEARCH:
                // do search
                break;
            default:
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid data must be number !");
    }
    catch (ArgumentNullException)
    {
        Console.WriteLine("No data provided");
    }
} while (choice != Choice.EXIT);


void PrintWelcome()
{
    Console.WriteLine("""
                      
                      ** Welcome To Simple Inventory Management System **
                      ===================================================
                      1. Add Product
                      2. View All Products
                      3. Edit Product
                      4. Delete Product
                      5. Search Product
                      6. Exit
                      """);
}

Product GetProductInfo()
{
    Console.Write("Name: ");
    string? name = Console.ReadLine();
    Console.Write("Price: ");
    double price = Double.Parse(Console.ReadLine());
    Console.Write("Quantity: ");
    int quantity = Int32.Parse(Console.ReadLine());

    return new Product(name, price, quantity);
}

void AddChoice()
{
    var productInfo = GetProductInfo();
    ops.AddProduct(productInfo.Name, productInfo.Price, productInfo.Quantity);
}

void ViewAllChoice()
{
    var products = ops.ViewProducts();
    foreach (string p in products)
    {
        Console.WriteLine(p.ToString());
    }
}