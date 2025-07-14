using Simple_Inventory_Management_System.logic;
using Simple_Inventory_Management_System.models.enums;


Choice choice = Choice.NONE;

do
{
    PrintWelcome();
    try
    {
        choice = (Choice)Int32.Parse(Console.ReadLine());
        switch (choice)
        {
            case Choice.ADD:
                // do add operation
                break;
            case Choice.VIEWALL:
                // do view all
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
        Console.WriteLine("Invalid Choice !");
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