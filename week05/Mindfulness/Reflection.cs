namespace Mindfulness
{
    class Reflection : Activity
    {
        protected string _prompt = new ReflectionLists()._prompt;
        protected string _followUpPrompt = new ReflectionLists()._followUpPrompt;

        public Reflection(int duration) : base("Reflection Activity", "This activity will help you reflect on positive aspects of your life by listing things you are grateful for.", duration) { }

        public void Prompt(int duration)
        {
            base.DisplayStartMessage();
            Console.WriteLine(_prompt);
            for (int i = duration / 2; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.WriteLine(_followUpPrompt);
            Console.WriteLine();
            for (int i = duration / 2; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            base.DisplayEndMessage();
        }
    }
}
