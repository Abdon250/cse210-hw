using System;
using System.Collections.Generic;



// Class representing the shopping mall
public class ShoppingMall
{
    private List<Item> stock;

    public ShoppingMall()
    {
        stock = new List<Item>();
        // Initialize stock with some items
        stock.Add(new Clothing("T-shirt", 19.99, 10, "M"));
        stock.Add(new Clothing("Jeans", 39.99, 5, "L"));
        stock.Add(new Electronics("Phone", 699.99, 3, "Apple"));
        stock.Add(new Electronics("Laptop", 1499.99, 2, "Dell"));
        stock.Add(new Food("Apple", 0.99, 20, new DateTime(2023, 12, 31)));
        stock.Add(new Food("Bread", 2.49, 15, new DateTime(2023, 6, 30)));
        stock.Add(new Furniture("Chair", 49.99, 8, "Wood"));
        stock.Add(new Furniture("Table", 99.99, 5, "Glass"));
    }

    public void DisplayStock()
    {
        Console.WriteLine("Items in Stock:");
        for (int i = 0; i < stock.Count; i++)
        {
            int displayIndex = i + 1; // Adjust the index to start from 1
            Console.Write($"{displayIndex}. ");
            stock[i].Display();
        }
    }

    public Item SelectItem()
    {
        Console.WriteLine("Enter the index of the item to select:");
        int index = Convert.ToInt32(Console.ReadLine());
        int adjustedIndex = index - 1; // Adjust the index to match the list index
        if (adjustedIndex >= 0 && adjustedIndex < stock.Count)
        {
            return stock[adjustedIndex];
        }
        else
        {
            Console.WriteLine("Invalid selection!");
            return null;
        }
    }
}