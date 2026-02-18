namespace EternalQuest
{
    public class EternalGoal(string name, string description, int points) : Goal(name, description, points)
    {
        private string _name = name;
        private string _description = description;
        private int _points = points;

        public override string ToString()
        {
            return $"[ ] {GetName()} ({GetDescription()}) - {GetPoints()} points";
        }

        public string SaveString()
        {
            return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
        }
    }
}