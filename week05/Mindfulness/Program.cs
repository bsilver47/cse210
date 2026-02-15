using System;

namespace Mindfulness
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mindfulness App!");
            Console.WriteLine("Please enter the amount of time you intend to be mindful in seconds: ");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing Exercise");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.Write("Enter the number of your choice: ");
            string choice = Console.ReadLine();



            switch (choice)
            {
                case "1":
                    // activity = new BreathingExercise();
                    // activity.Prompt();
                    BreathingExercise exercise = new BreathingExercise(duration);
                    exercise.Prompt(duration);
                    break;
                case "2":
                    // activity = new Reflection();
                    // activity.Prompt();
                    Reflection reflection = new Reflection(duration);
                    reflection.Prompt(duration);
                    break;
                case "3":
                    // activity = new Listing();
                    // activity.Prompt();
                    Listing listing = new Listing(duration);
                    listing.Prompt(duration);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Exiting the program.");
                    return;
            }
        }
    }
}