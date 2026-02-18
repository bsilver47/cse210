namespace EternalQuest
{
    public class ChecklistGoal(string name, string description, int points, int timesCompleted, int timesToComplete) : Goal(name, description, points)
    {
        private string _name = name;
        private string _description = description;
        private int _points = points;
        private int _timesCompleted = timesCompleted;
        private int _timesToComplete = timesToComplete;

        public void RecordEvent()
        {
            _timesCompleted++;
        }

        public bool IsComplete()
        {
            return _timesCompleted >= _timesToComplete;
        }

        public override string ToString()
        {
            string status = IsComplete() ? "X" : " ";
            return $"[{status}] {GetName()} ({GetDescription()}) - {GetPoints()} points - Completed {_timesCompleted}/{_timesToComplete} times";
        }

        public string SaveString()
        {
            return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_timesCompleted}|{_timesToComplete}";
        }
    }
}