namespace ExerciseTracking
{
    public class StationaryBicycles : Exercise
    {
        public StationaryBicycles(string name, int duration, DateOnly date, float speed) : base(name, duration, date)
        {
            _distance = CalculateDistance(speed);
            _speed = speed;
            _pace = CalculatePace();
        }
    }
}