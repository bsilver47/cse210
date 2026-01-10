using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;
        while (playAgain)
        {
            Random random = new Random();
            int number = random.Next(1, 101);
            Console.WriteLine("What is your guess?");
            int guess = int.Parse(Console.ReadLine());
            int attempts = 1;
            while (guess != number)
            {
                if (guess < number)
                {
                    Console.WriteLine("Too low. Guess again:");
                }
                else
                {
                    Console.WriteLine("Too high. Guess again:");
                }
                guess = int.Parse(Console.ReadLine());
                attempts++;
            }
            Console.WriteLine("Congratulations! You guessed the number!");
            Console.WriteLine($"It took you {attempts} attempts to guess the number.");
            Console.WriteLine("Do you want to play again? (yes/no)");
            string response = Console.ReadLine().ToLower();
            if (response != "yes")
            {
                playAgain = false;
            }
        }
    }
}