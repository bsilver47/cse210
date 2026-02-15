using System;

namespace Mindfulness
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mindfulness App!");
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing Exercise");
            Console.WriteLine("2. Body Scan");
            Console.WriteLine("3. Guided Meditation");
            Console.Write("Enter the number of your choice: ");
            string choice = Console.ReadLine();

            Activity activity;
            switch (choice)
            {
                case "1":
                    activity = new BreathingExercise();
                    break;
                case "2":
                    activity = new Reflection();
                    break;
                case "3":
                    activity = new Listing();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Exiting the program.");
                    return;
            }
            activity.DisplayStartMessage();
            activity.SetDuration(60); // Set a default duration of 60 seconds
            activity.DisplayEndMessage();
        }
    }
}