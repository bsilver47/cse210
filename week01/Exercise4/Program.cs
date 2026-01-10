using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNum = -1;
        while (newNum != 0)
        {
            Console.WriteLine("Enter a number (0 to quit):");
            newNum = int.Parse(Console.ReadLine());
            if (newNum != 0)
            {
                numbers.Add(newNum);
            }
        }
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum / numbers.Count}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
        Console.WriteLine($"The smallest positive number is: {numbers.Where(n => n > 0).Min()}");
        Console.WriteLine("The numbers in sorted order are:");
        List<int> sortedNumbers = numbers.OrderBy(n => n).ToList();
        foreach (int num in sortedNumbers)
        {
            Console.WriteLine(num);
        }
    }
}