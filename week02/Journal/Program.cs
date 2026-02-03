using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your journal!");
        // Get entry per Entry class and get file name to save entry to that location with all others
        Entry entry = new Entry();
        entry._date = DateTime.Now;
        entry._prompt = new Prompt()._prompt;
        Console.WriteLine(entry._prompt);
        entry._passage = Console.ReadLine();
        entry.DisplayEntry();
    }
}