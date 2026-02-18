using System;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Exercise> exercises = new List<Exercise>();
            exercises.Add(new Running("Morning Run", 30, DateOnly.FromDateTime(DateTime.Now), 3.0f));
            exercises.Add(new StationaryBicycles("Stationary Bike", 45, DateOnly.FromDateTime(DateTime.Now), 12.0f));
            exercises.Add(new Swimming("Swimming", 60, DateOnly.FromDateTime(DateTime.Now), 20.0f));

            Console.WriteLine("Exercise Summary:");
            Console.WriteLine();

            foreach (Exercise exercise in exercises)
            {
                Console.WriteLine(exercise.Summary());
            }
        }
    }
}