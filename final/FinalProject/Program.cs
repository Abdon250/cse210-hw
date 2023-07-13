using System;
using System.Collections.Generic;


// Main program
public class Program
{
    public static void Main(string[] args)
    {
        ShoppingMall mall = new ShoppingMall();
        ShoppingCart cart = new ShoppingCart();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add item to cart");
            Console.WriteLine("2. Remove item from cart");
            Console.WriteLine("3. Display cart");
            Console.WriteLine("4. Update cart");
            Console.WriteLine("5. Give bonus on weekends");
            Console.WriteLine("6. Quit");

            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    mall.DisplayStock();
                    Item selectedItem = mall.SelectItem();
                    if (selectedItem != null)
                    {
                        Console.WriteLine("Enter the quantity:");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        if (cart.CheckAvailability(selectedItem, quantity))
                        {
                            selectedItem.Quantity = quantity;
                            cart.AddToCart(selectedItem);
                            Console.WriteLine("Item added to cart.");
                        }
                    }
                    break;

                case 2:
                    cart.DisplayCart();
                    Console.WriteLine("Enter the index of the item to remove:");
                    int removeIndex = Convert.ToInt32(Console.ReadLine());
                    if (removeIndex >= 1 && removeIndex <= cart.DisplayCart().Count)
                    {
                        Item itemToRemove = cart.GetItemAtIndex(removeIndex - 1);
                        cart.RemoveFromCart(itemToRemove);
                        Console.WriteLine("Item removed from cart.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid index!");
                    }
                    break;

                case 3:
                    cart.DisplayCart();
                    Console.WriteLine($"Total: ${cart.CalculateTotal()}");
                    break;

                case 4:
                    cart.DisplayCart();
                    cart.UpdateCart(mall);
                    double removedItemsPrice = cart.CalculateRemovedItemsPrice();
                    double total = cart.CalculateTotal() - removedItemsPrice;
                    Console.WriteLine($"Total: ${total}");
                    break;

                case 5:
                    DateTime currentDate = DateTime.Now;
                    if (currentDate.DayOfWeek == DayOfWeek.Saturday || currentDate.DayOfWeek == DayOfWeek.Sunday)
                    {
                        foreach (Item item in cart.DisplayCart())
                        {
                            item.Price *= 0.9; // Reduce the price by 10%
                        }
                        Console.WriteLine("10% discount applied to the cart items.");
                    }
                    else
                    {
                        Console.WriteLine("Today is not a weekend day.");
                    }
                    break;

                case 6:
                    Console.WriteLine("Thank you for shopping!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
