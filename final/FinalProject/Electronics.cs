using System;
using System.Collections.Generic;


// Derived class representing a specific item (e.g., electronics)
public class Electronics : Item
{
    public string Brand { get; set; }

    public Electronics(string name, double price, int quantity, string brand)
        : base(name, price, quantity)
    {
        Brand = brand;
    }

    public override void Display()
    {
        Console.WriteLine($"Electronics: {Name} - Brand: {Brand} - Price: ${Price} - Quantity: {Quantity}");
    }
}
