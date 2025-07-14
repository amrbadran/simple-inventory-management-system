using System.Diagnostics.CodeAnalysis;

namespace Simple_Inventory_Management_System.models;

public class Product
{
    [SetsRequiredMembers]
    public Product(string name, double price, int quantity)
    {
        this.Name = name;
        this.Price = price;
        this.Quantity = quantity;
    }

    public required string Name { get; set; }
    public required double Price { get; set; }
    public required int Quantity { get; set; }

    public override string ToString()
    {
        return $"Name: {this.Name} | Price: {this.Price} | Quantity: {this.Quantity}";
    }
}