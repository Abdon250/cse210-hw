using System;
using System.Collections.Generic;


// Derived class representing a specific item (e.g., food)
public class Food : Item
{
    public DateTime ExpirationDate { get; set; }

    public Food(string name, double price, int quantity, DateTime expirationDate)
        : base(name, price, quantity)
    {
        ExpirationDate = expirationDate;
    }

    public override void Display()
    {
        Console.WriteLine($"Food: {Name} - Expiration Date: {ExpirationDate} - Price: ${Price} - Quantity: {Quantity}");
    }
}
