using System.Diagnostics;

namespace Mindfulness
{
    class Listing : Activity
    {
        protected string _prompt = new ListingLists()._prompt;
        public Listing(int duration) : base("Listing Activity", "This activity will help you reflect on positive aspects of your life by listing things you are grateful for.", duration) { }

        public void Prompt(int duration)
        {
            List<string> entries = new List<string>();
            Stopwatch stopwatch = new Stopwatch();
            base.DisplayStartMessage();
            Console.WriteLine(_prompt);
            Console.WriteLine("Get ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go!");
            stopwatch.Start();
            while (stopwatch.Elapsed.TotalSeconds < duration)
            {
                Console.Write("> ");
                string entry = Console.ReadLine();
                entries.Add(entry);
            }
            stopwatch.Stop();
            Console.WriteLine($"You listed {entries.Count} items!");
            base.DisplayEndMessage();
        }
    }
}