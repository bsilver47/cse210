namespace EternalQuest
{
    public class Goal
    {
        private string _name;
        private string _description;
        private int _points;
        private bool _isComplete;

        public Goal(string name, string description, int points, bool isComplete = false)
        {
            _name = name;
            _description = description;
            _points = points;
            _isComplete = isComplete;
        }

        protected void CreateGoal()
        {
            Console.Write("What is the name of your goal? ");
            _name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            _description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            _points = int.Parse(Console.ReadLine());

            _isComplete = false;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetDescription()
        {
            return _description;
        }

        public int GetPoints()
        {
            return _points;
        }
    }
}