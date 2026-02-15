
namespace Mindfulness;

public class ReflectionLists
{
    static List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you truly enjoyed talking with someone.",
        "Think of a time when you saw the Lord directing your life.",
        "Think of a time when you were truly grateful.",
        "Think of a time when you accomplished something significant.",
        "Think of a time when you were touched by someone's kindness.",
        "Think of a time when you felt the Holy Ghost in your life.",
        "Think of a time when you learned something new about yourself or someone around you.",
    };

    static List<string> _followUpPrompts = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "Have you ever shared this experience with anyone else?",
        "How did you feel when it was complete?",
        "How did you get started?",
        "What made this time different than other times when you were not as successful?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        "How can you replicate this for yourself or someone else going forward?",
        "What surprised you about this experience?",
    };

    public string _prompt = _prompts[Random.Shared.Next(_prompts.Count)];
    public string _followUpPrompt = _followUpPrompts[Random.Shared.Next(_followUpPrompts.Count)];

    public void DisplayEntry()
    {
        Console.WriteLine("Prompt:");
        Console.WriteLine(_prompt);
    }
}