using System;


namespace Mindfulness
{
    class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        public Activity(string name, string description, int duration)
        {
            _name = name;
            _description = description;
            _duration = duration;
        }

        public void DisplayStartMessage()
        {
            Console.WriteLine($"Welcome to the {_name} activity!");
            Console.WriteLine(_description);
            Console.WriteLine("Get ready to begin...");
            Console.WriteLine();
            Thread.Sleep(3000);
        }

        public void DisplayEndMessage()
        {
            Console.WriteLine("Well done! You have completed the activity.");
            Console.WriteLine($"You spent {_duration} seconds on this activity.");
            Console.WriteLine("Take a moment to reflect on how you felt during the activity.");
            Console.WriteLine();
            Thread.Sleep(3000);
        }

        public void SetDuration(int duration)
        {
            _duration = duration;
        }
    }
}