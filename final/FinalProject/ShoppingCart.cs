using System;
using System.Collections.Generic;


// Class representing the shopping cart
public class ShoppingCart
{
    private List<Item> items;
    private List<Item> removedItems;

    public ShoppingCart()
    {
        items = new List<Item>();
        removedItems = new List<Item>();
    }

    public void AddToCart(Item item)
    {
        items.Add(item);
    }

    public void RemoveFromCart(Item item)
    {
        items.Remove(item);
        removedItems.Add(item);
    }

    public Item GetItemAtIndex(int index)
    {
        return items[index];
    }

    public List<Item> DisplayCart()
    {
        Console.WriteLine("Shopping Cart:");
        List<Item> cartItems = new List<Item>();
        for (int i = 0; i < items.Count; i++)
        {
            cartItems.Add(items[i]);
            Console.WriteLine($"{i + 1}. {items[i].Name}");
        }
        return cartItems;
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (Item item in items)
        {
            total += item.Price * item.Quantity;
        }
        return total;
    }

    public bool CheckAvailability(Item item, int quantity)
    {
        if (item.Quantity >= quantity)
        {
            return true;
        }
        else
        {
            Console.WriteLine("We don't have enough product in stock.");
            return false;
        }
    }

    public void UpdateCart(ShoppingMall mall)
    {
        while (true)
        {
            Console.WriteLine("\nUpdate Cart:");
            Console.WriteLine("1. Add item");
            Console.WriteLine("2. Remove item");
            Console.WriteLine("3. Back to main menu");

            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    mall.DisplayStock();
                    Item addItem = mall.SelectItem();
                    if (addItem != null)
                    {
                        Console.WriteLine("Enter the quantity to add:");
                        int addQuantity = Convert.ToInt32(Console.ReadLine());
                        if (CheckAvailability(addItem, addQuantity))
                        {
                            addItem.Quantity = addQuantity;
                            AddToCart(addItem);
                            Console.WriteLine("Item added to cart.");
                        }
                    }
                    break;

                case 2:
                    DisplayCart();
                    Console.WriteLine("Enter the index of the item to remove:");
                    int removeIndex = Convert.ToInt32(Console.ReadLine());
                    if (removeIndex >= 1 && removeIndex <= DisplayCart().Count)
                    {
                        Item removeItem = GetItemAtIndex(removeIndex - 1);
                        Console.WriteLine("Enter the quantity to remove:");
                        int removeQuantity = Convert.ToInt32(Console.ReadLine());
                        if (removeQuantity <= removeItem.Quantity)
                        {
                            removeItem.Quantity = removeQuantity;
                            RemoveFromCart(removeItem);
                            Console.WriteLine("Item removed from cart.");
                        }
                        else
                        {
                            Console.WriteLine("Quantity to remove exceeds the quantity in the cart.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid index!");
                    }
                    break;

                case 3:
                    return;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    public double CalculateRemovedItemsPrice()
    {
        double removedItemsPrice = 0;
        foreach (Item item in removedItems)
        {
            removedItemsPrice += item.Price * item.Quantity;
        }
        return removedItemsPrice;
    }
}