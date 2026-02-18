namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            string selectedFromMenu = "";
            GoalManager goalManager = new GoalManager();

            while (selectedFromMenu != "6")
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");
                Console.Write("Select a choice from the menu: ");
                selectedFromMenu = Console.ReadLine();

                switch (selectedFromMenu)
                {
                    case "1":
                        Console.WriteLine("Select the type of goal to create:");
                        Console.WriteLine("1. Simple Goal");
                        Console.WriteLine("2. Checklist Goal");
                        Console.Write("3. Eternal Goal");
                        Console.Write("Goal Type: ");
                        string goalType = Console.ReadLine();
                        switch (goalType)
                        {
                            case "1":
                                Console.WriteLine("What is the name of this goal? ");
                                string simpleName = Console.ReadLine();
                                Console.Write("What is a short description of it? ");
                                string simpleDescription = Console.ReadLine();
                                Console.Write("What is the amount of points associated with this goal? ");
                                int simplePoints = int.Parse(Console.ReadLine());
                                SimpleGoal simpleGoal = new SimpleGoal(simpleName, simpleDescription, simplePoints);
                                goalManager.AddGoal(simpleGoal);
                                break;
                            case "2":
                                Console.Write("What is the name of this goal? ");
                                string name = Console.ReadLine();
                                Console.Write("What is a short description of it? ");
                                string description = Console.ReadLine();
                                Console.Write("What is the amount of points associated with this goal? ");
                                int points = int.Parse(Console.ReadLine());
                                Console.Write("How many times does this goal need to be completed? ");
                                int timesToComplete = int.Parse(Console.ReadLine());
                                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, 0, timesToComplete);
                                goalManager.AddGoal(checklistGoal);
                                break;
                            case "3":
                                Console.Write("What is the name of this goal? ");
                                string eternalName = Console.ReadLine();
                                Console.Write("What is a short description of it? ");
                                string eternalDescription = Console.ReadLine();
                                Console.Write("What is the amount of points associated with this goal? ");
                                int eternalPoints = int.Parse(Console.ReadLine());
                                EternalGoal eternalGoal = new EternalGoal(eternalName, eternalDescription, eternalPoints);
                                goalManager.AddGoal(eternalGoal);
                                break;
                            default:
                                Console.WriteLine("Invalid goal type, please try again.");
                                break;
                        }
                        break;
                    case "2":
                        goalManager.DisplayGoals();
                        break;
                    case "3":
                        goalManager.SaveGoals("goals.txt");
                        break;
                    case "4":
                        goalManager.LoadGoals("goals.txt");
                        break;
                    case "5":
                        Console.WriteLine("Which goal would you like to record an event for?");
                        goalManager.DisplayGoals();
                        int goalIndex = int.Parse(Console.ReadLine()) - 1;
                        goalManager.RecordEvent(goalIndex);
                        break;
                    case "6":
                        Console.WriteLine("Goodbye!");
                        break;
                    case "Konami":
                        goalManager.KonamiCode(); // This is for creative and administrative purposes
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
    }
}