namespace Simple_Inventory_Management_System.models.interfaces;

public interface IInventoryCRUD
{
    public void AddProduct(String name, double price, int quantity);
    public List<string> ViewProducts();
    public void EditProduct(int indexProduct, string name, double price, int quantity);
    public void DeleteProduct(int indexProduct);
    public String SearchProduct(int indexProduct);
    
}