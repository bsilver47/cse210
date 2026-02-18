namespace ExerciseTracking
{
    public class Running : Exercise
    {
        public Running(string name, int duration, DateOnly date, float distance) : base(name, duration, date)
        {
            _distance = distance;
            _speed = CalculateSpeed();
            _pace = CalculatePace();
        }
    }
}