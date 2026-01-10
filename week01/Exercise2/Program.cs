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
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (letterGrade != "F")
        {
            int lastDigit = gradePercentage % 10;
            if (lastDigit >= 7 && letterGrade != "A")
            {
                letterGrade += "+";
            }
            else if (lastDigit < 3)
            {
                letterGrade += "-";
            }
        }

        Console.WriteLine($"Your letter grade is {letterGrade}.");

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