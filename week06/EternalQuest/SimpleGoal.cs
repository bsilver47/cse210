using System.Net;

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private string _name;
        private string _description;
        private int _points;
        private bool _isComplete;

        public SimpleGoal(string name, string description, int points, bool isComplete = false) : base(name, description, points, isComplete)
        {
            _name = name;
            _description = description;
            _points = points;
            _isComplete = isComplete;
        }

        public void RecordEvent()
        {
            if (!_isComplete)
            {
                _isComplete = true;
            }
            else
            {
                Console.WriteLine("This goal has already been completed.");
            }
        }

        public bool IsComplete()
        {
            return _isComplete;
        }

        public override string ToString()
        {
            string status = IsComplete() ? "X" : " ";
            return $"[{status}] {GetName()} ({GetDescription()}) - {GetPoints()} points";
        }

        public string SaveString()
        {
            return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{IsComplete()}";
        }
    }
}