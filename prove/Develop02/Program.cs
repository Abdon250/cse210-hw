using System;

class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            PromptGenerator promptGenerator = new PromptGenerator();
            string fileName;
            
            
            while (true)
            {
                Console.WriteLine("1. Write   \n2. Display   \n3. Load   \n4. Save   \n5. Quit");
                Console.WriteLine("What would you like to do?");
                string choice = Console.ReadLine();
                
                if(choice == "1")
                {
                     string prompt = promptGenerator.GeneratePrompt();
                        Console.WriteLine(prompt);
                        string answer = Console.ReadLine();
                        Entry entry = new Entry(prompt, answer);
                        journal.AddEntry(entry);
                        Console.WriteLine("Entry added successfully!");
                }else if (choice == "2")
                {
                }else if (choice == "3")
                {   Console.WriteLine("enter file name to load");
                        fileName = Console.ReadLine();
                        journal.LoadFromFile(fileName);
                        Console.WriteLine("Entries loaded successfully!");
                }else if (choice == "4")
                {
                    Console.WriteLine("Enter file name to save to:");
                        fileName = Console.ReadLine();
                        journal.SaveToFile(fileName);
                        Console.WriteLine("Entries saved successfully!");
                }else if (choice == "5")
                {
                    Console.WriteLine("Goodbye!");
                    break;
     
                }else{
                    Console.WriteLine("Invalid choice, please select one of the following choices:");
                }

                
                Console.WriteLine("Please select one of the following choices:");
                
                
            }
        }
    }