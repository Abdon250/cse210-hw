using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create an instance of the Scripture class with a specific reference and text
        Scripture scripture = new Scripture("1 Nephi 1:1", "I, Nephi, having been aborn of bgoodly cparents, therefore I was dtaught somewhat in all the learning of my father; and having seen many eafflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a frecord of my proceedings in my days.");

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




