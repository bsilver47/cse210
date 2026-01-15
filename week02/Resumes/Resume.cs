public class Resume
{
    public string _name { get; set; }
    public List<Job> _jobs { get; set; }
    public Resume(string name)
    {
        _name = name;
        _jobs = new List<Job>();
    }

    public void DisplayResume()
    {
        Console.WriteLine(_name);
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJob();
        }
    }
}