namespace Mindfulness
{
    class Listing : Activity
    {
        protected string _prompt = new ListingLists()._prompt;
        public Listing() : base("Listing Activity", "This activity will help you reflect on positive aspects of your life by listing things you are grateful for.", 0) { }

        protected void Prompt()
        {
            base.DisplayStartMessage();
            Console.WriteLine(_prompt);
            Console.WriteLine("Get ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go!");
            Thread.Sleep(_duration * 1000);
        }
    }
}