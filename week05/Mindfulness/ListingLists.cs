namespace Mindfulness;
public class ListingLists
{
    static List<string> _prompts = new List<string>()
    {
        "Who were the people I was glad to interact with today?",
        "What were the best parts of my day?",
        "In what ways did I see the hand of the Lord in my life today?",
        "What were the moments I felt strong emotions today?",
        "What are some things I am looking forward to implementing in my day tomorrow?",
        "What are some things I am grateful for today?",
        "What are some goals I have for tomorrow?",
        "Who are people that had a positive impact on my life today?",
        "What have I learned today?",
        "Who do I want to reach out to and express appreciation for tomorrow?",
        "What are some of my personal strengths?",
        "Who have I helped this week?",
        "When have I felt the Holy Ghost this week?",
        "Who are some of my heroes?",
    };

    public string _prompt = _prompts[Random.Shared.Next(_prompts.Count)];

    public void DisplayEntry()
    {
        Console.WriteLine("Prompt:");
        Console.WriteLine(_prompt);
    }
}