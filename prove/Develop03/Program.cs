using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create an instance of the Scripture class with a specific reference and text
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        while (true)
        {
            Console.Clear();
            scripture.DisplayScripture();

            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWord();
        }
    }
}




