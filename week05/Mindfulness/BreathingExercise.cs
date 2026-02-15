using System;
using System.Diagnostics;

namespace Mindfulness
{
    class BreathingExercise : Activity
    {
        public BreathingExercise(int duration) : base("Breathing Exercise", "This activity will help you focus on your breath and relax your mind.", duration) { }

        public void Prompt(int duration)
        {
            base.DisplayStartMessage();
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Starting...");
            stopwatch.Start();
            Console.WriteLine("Now!");
            while (stopwatch.Elapsed.TotalSeconds < duration)
            {
                Console.WriteLine("Hold your breath for 4 seconds...");
                Thread.Sleep(4000);
                Console.WriteLine("Inhale deeply through your nose for 4 seconds...");
                Thread.Sleep(4000);
                Console.WriteLine("Hold your breath for 7 seconds...");
                Thread.Sleep(7000);
                Console.WriteLine("Exhale slowly through your mouth for 4 seconds...");
                Thread.Sleep(4000);
            }
            stopwatch.Stop();
            Console.WriteLine("Great job! You completed the breathing exercise.");
            Console.WriteLine("Please begin breathing normally now");
            base.DisplayEndMessage();
        }
    }
}