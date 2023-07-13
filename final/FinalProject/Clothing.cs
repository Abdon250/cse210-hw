using System;
using System.Collections.Generic;




// Derived class representing a specific item (e.g., clothing)
public class Clothing : Item
{
    public string Size { get; set; }

    public Clothing(string name, double price, int quantity, string size)
        : base(name, price, quantity)
    {
        Size = size;
    }

    public override void Display()
    {
        Console.WriteLine($"Clothing: {Name} - Size: {Size} - Price: ${Price} - Quantity: {Quantity}");
    }
}
