using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your journal!");
        Console.Write("Please enter the filename for your journal: ");
        string fileName = Console.ReadLine();
        if (string.IsNullOrEmpty(fileName))
        {
            fileName = "journal.csv"; // note as the default shows, this is designed to be a CSV file
        }
        if (!File.Exists(fileName))
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine("Date, Prompt, Passage");
            }
        }

        Entry entry = new Entry();
        entry._date = DateTime.Now;
        entry._prompt = new Prompt()._prompt;
        Console.WriteLine(entry._prompt);
        entry._passage = Console.ReadLine();
        entry.DisplayEntry();
        entry.WriteToFile(fileName);
        Console.WriteLine("Your entry has been saved!");
    }
}