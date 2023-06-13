using System;
using System.Threading;

public class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            DisplayMenu();
            int choice = GetMenuChoice();

            if (choice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.PerformBreathingActivity();
            }
            else if (choice == 2)
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.PerformReflectionActivity();
            }
            else if (choice == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.PerformListingActivity();
            }
            else if (choice == 4)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("=== Mindfulness Program ===");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("===========================");
    }

    static int GetMenuChoice()
    {
        Console.Write("Enter your choice: ");
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid choice. Please enter a valid number.");
            Console.Write("Enter your choice: ");
        }
        return choice;
    }
}
