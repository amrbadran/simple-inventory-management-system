using Simple_Inventory_Management_System.models;

namespace Simple_Inventory_Management_System.logic;

public class InventoryOperations
{
    private Inventory inventory;

    public InventoryOperations()
    {
        this.inventory = Inventory.GetInventory();
    }

    public void AddProduct(String name, double price, int quantity)
    {
        Product p = new Product(name, price, quantity);
        inventory.Products.Add(p);
    }
}