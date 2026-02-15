using System;

namespace Mindfulness
{
    class BreathingExercise : Activity
    {
        public BreathingExercise() : base("Breathing Exercise", "This activity will help you focus on your breath and relax your mind.", 0) { }

        protected void Prompt()
        {
            base.DisplayStartMessage();
            Console.WriteLine("Inhale deeply through your nose for 4 seconds...");
            Thread.Sleep(4000);
            Console.WriteLine("Hold your breath for 7 seconds...");
            Thread.Sleep(7000);
            Console.WriteLine("Exhale slowly through your mouth for 4 seconds...");
            Thread.Sleep(4000);
        }
    }
}