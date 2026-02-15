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
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.Write("Enter the number of your choice: ");
            string choice = Console.ReadLine();

            Activity activity;
            switch (choice)
            {
                case "1":
                    // activity = new BreathingExercise();
                    // activity.Prompt();
                    BreathingExercise breathingExercise = new BreathingExercise();
                    breathingExercise.Prompt();
                    break;
                case "2":
                    activity = new Reflection();
                    activity.Prompt();

                    break;
                case "3":
                    activity = new Listing();
                    activity.Prompt();
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