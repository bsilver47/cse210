public class Entry
{
    public DateTime _date { get; set; } // DateTime; current date? current time?
    public string _prompt { get; set; } // class to pull one random string from list
    public string _passage { get; set; } // class?

    public Entry() { }

    public Entry(DateTime _date, string _prompt, string _passage)
    {
        this._date = DateTime.Now;
        this._prompt = _prompt;
        this._passage = _passage;
    }


    public void DisplayEntry()
    {
        Console.WriteLine(_date);
        Console.WriteLine("Prompt:");
        Console.WriteLine(_prompt);
        Console.WriteLine("Passage:");
        Console.WriteLine(_passage);
    }

    public void WriteToFile(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            outputFile.WriteLine(_date.ToString("yyyy-MM-dd HH:mm:ss") + ", " + _prompt + ", " + _passage);
        }
    }
}