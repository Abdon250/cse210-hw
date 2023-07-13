using System;
using System.Collections.Generic;


// Derived class representing a specific item (e.g., furniture)
public class Furniture : Item
{
    public string Material { get; set; }

    public Furniture(string name, double price, int quantity, string material)
        : base(name, price, quantity)
    {
        Material = material;
    }

    public override void Display()
    {
        Console.WriteLine($"Furniture: {Name} - Material: {Material} - Price: ${Price} - Quantity: {Quantity}");
    }
}