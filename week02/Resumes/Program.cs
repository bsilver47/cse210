using System;


class Program
{
    static void Main(string[] args)
    {
        Job job1 = new("Software Engineer", "Microsoft", 2019, 2023);
        Job job2 = new("Manager", "Apple", 2023, 2024);
        Resume resume = new("Benjamin");
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.DisplayResume();
    }
}