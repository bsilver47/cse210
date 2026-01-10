using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the grade percentage?");
        int gradePercentage = int.Parse(Console.ReadLine());
        string letterGrade = "";

        if (gradePercentage >= 90)
        {
            Console.WriteLine("Your letter grade is A.");
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("Your letter grade is B.");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("Your letter grade is C.");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("Your letter grade is D.");
        }
        else
        {
            Console.WriteLine("Your letter grade is F.");
        }

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You have passed!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you have not passed the course. Better luck next time!");
        }
    }
}

// {
//     Console.WriteLine("What is your first name?");
//     string firstName = Console.ReadLine();
//     Console.WriteLine("What is your last name?");
//     string lastName = Console.ReadLine();
//     Console.WriteLine($"That means you are {lastName}, {firstName} {lastName}");
// }
// }