using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your journal!");
        Console.WriteLine("Please enter the filename for your journal: ");
        string fileName = Console.ReadLine();
        if (string.IsNullOrEmpty(fileName))
        {
            fileName = "journal.csv"; // note as the default shows, this is designed to be a CSV file, which is designed to support the creative requirement
        }
        if (!File.Exists(fileName))
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine("Date, Prompt, Passage");
            }
        }

        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Write a new journal entry");
        Console.WriteLine("2. Display all journal entries");
        Console.WriteLine("3. Exit");
        string choice = Console.ReadLine();
        while (choice != "3")
        {
            if (choice == "1")
            {
                Entry entry = new Entry();
                entry._date = DateTime.Now;
                entry._prompt = new Prompt()._prompt;
                Console.WriteLine(entry._prompt);
                entry._passage = Console.ReadLine();
                entry.DisplayEntry();
                entry.WriteToFile(fileName);
                Console.WriteLine("Your entry has been saved!");
            }
            else if (choice == "2")
            {
                DisplayEntries(fileName);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display all journal entries");
            Console.WriteLine("3. Exit");
            choice = Console.ReadLine();
        }
        Console.WriteLine("Thank you for using your journal. Goodbye!");
    }

    // }
}