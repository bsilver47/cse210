namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals;
        private int _totalPoints;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _totalPoints = 0;
        }

        public void AddGoal(Goal goal)
        {
            _goals.Add(goal);
        }

        public void RecordEvent(int index)
        {
            if (index >= 0 && index < _goals.Count)
            {
                Goal goal = _goals[index];
                if (goal is SimpleGoal simpleGoal)
                {
                    simpleGoal.RecordEvent();
                    if (simpleGoal.IsComplete())
                    {
                        _totalPoints += simpleGoal.GetPoints();
                    }
                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    checklistGoal.RecordEvent();
                    if (!checklistGoal.IsComplete())
                    {
                        _totalPoints += checklistGoal.GetPoints();
                    }
                }
                else if (goal is EternalGoal eternalGoal)
                {
                    _totalPoints += eternalGoal.GetPoints();
                }
            }
            else
            {
                Console.WriteLine("Invalid goal index.");
            }
        }

        public void DisplayGoals()
        {
            Console.WriteLine("Your Goals:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i]}");
            }
            Console.WriteLine($"Total Points: {_totalPoints}");
        }

        public void SaveGoals(string filename) // reconfigure to save progress and points when saved
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_totalPoints); // Save total points first
                foreach (var goal in _goals)
                {
                    if (goal is SimpleGoal simpleGoal)
                    {
                        writer.WriteLine(simpleGoal.SaveString());
                    }
                    else if (goal is ChecklistGoal checklistGoal)
                    {
                        writer.WriteLine(checklistGoal.SaveString());
                    }
                    else if (goal is EternalGoal eternalGoal)
                    {
                        writer.WriteLine(eternalGoal.SaveString());
                    }
                }
            }
        }

        public void KonamiCode()
        {
            Console.WriteLine("You have unlocked the secret Konami code! Congratulations!");
            Console.WriteLine("How many points would you like to add? ");
            int pointsToAdd = int.Parse(Console.ReadLine());
            _totalPoints += pointsToAdd;
            // Implement any special functionality for the Konami code here
        }

        public void LoadGoals(string filename)
        {
            if (File.Exists(filename))
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        try

                        {


                            string[] parts = line.Split('|');
                            string type = parts[0];
                            string name = parts[1];
                            string description = parts[2];
                            int points = int.Parse(parts[3]);

                            if (type == "SimpleGoal")
                            {
                                bool isComplete = bool.Parse(parts[4]);
                                _goals.Add(new SimpleGoal(name, description, points, isComplete));
                            }
                            else if (type == "ChecklistGoal")
                            {
                                int timesCompleted = int.Parse(parts[4]);
                                int timesToComplete = int.Parse(parts[5]);
                                _goals.Add(new ChecklistGoal(name, description, points, timesCompleted, timesToComplete));
                            }
                            else if (type == "EternalGoal")
                            {
                                _goals.Add(new EternalGoal(name, description, points));
                            }
                        }
                        catch (Exception ex)
                        {
                            _totalPoints += int.Parse(line);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}