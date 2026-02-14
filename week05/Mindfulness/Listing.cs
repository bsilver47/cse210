namespace Mindfulness
{
    class Listing : Activity
    {
        public Listing(int duration) : base("Listing Activity", "This activity will help you reflect on positive aspects of your life by listing things you are grateful for.", duration) { }

        protected override void Prompt()
        {
            base.DisplayStartMessage();
            Console.WriteLine("Take a moment to think about the things you are grateful for in your life.");
            Console.WriteLine("You can list anything that brings you joy, comfort, or happiness.");
            Console.WriteLine("Start listing now...");
            Thread.Sleep(_duration * 1000);
        }
    }
}