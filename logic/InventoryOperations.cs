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

    public List<string> ViewProducts()
    {
        var productsMessages = new List<string>();
        foreach (Product p in inventory.Products)
        {
            productsMessages.Add(p.ToString());
        }

        return productsMessages;
    }

    public void EditProduct(int indexProduct, string name, double price, int quantity)
    {
        inventory.Products[indexProduct].Name = name;
        inventory.Products[indexProduct].Price = price;
        inventory.Products[indexProduct].Quantity = quantity;
    }

    public void DeleteProduct(int indexProduct)
    {
        if (indexProduct > 0)
        {
            inventory.Products.RemoveAt(indexProduct);
        }
    }

    public int ProductExists(string name)
    {
        for (int i = 0; i < inventory.Products.Count; ++i)
        {
            if (inventory.Products[i].Name == name)
                return i;
        }

        return -1;
    }
}