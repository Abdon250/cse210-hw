using System;
using System.Collections.Generic;

// Abstract class for an item in the store
public abstract class Item
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Item(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public abstract void Display();
}