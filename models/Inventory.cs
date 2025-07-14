namespace Simple_Inventory_Management_System.models;

public class Inventory
{
    private Inventory()
    {
        this.Products = new List<Product>();
    }

    private static Inventory? _inventoryObject;
    public List<Product> Products { get; }

    public static Inventory GetInventory()
    {
        if (_inventoryObject == null)
        {
            _inventoryObject = new Inventory();
        }

        return _inventoryObject;
    }
}