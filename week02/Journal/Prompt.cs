public class Prompt
{
    static List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be; and how can I implement that in my day tomorrow?",
        "What am I grateful for today?",
        "What is a goal I have for tomorrow?",
        "Who had a positive impact on my life today?",
        "What is something new I learned today?",
        "Who do I want to reach out to tomorrow?",
    };

    // Random _random = Random.Shared;
    // int index = _random.Next(_prompts.Count);

    public string _prompt = _prompts[Random.Shared.Next(_prompts.Count)];



    public void DisplayEntry()
    {
        Console.WriteLine("Prompt:");
        Console.WriteLine(_prompt);
    }
}