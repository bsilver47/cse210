namespace Mindfulness
{
    class Reflection : Activity
    {
        protected string _prompt = new ReflectionLists()._prompt;
        protected string _followUpPrompt = new ReflectionLists()._followUpPrompt;

        public Reflection() : base("Reflection Activity", "This activity will help you reflect on positive aspects of your life by listing things you are grateful for.", 0) { }

        public void Prompt()
        {
            base.DisplayStartMessage();
            Console.WriteLine(_prompt);
            for (int i = _duration / 2; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.WriteLine(_followUpPrompt);
            Console.WriteLine();
            for (int i = _duration / 2; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            base.DisplayEndMessage();
        }
    }
}
