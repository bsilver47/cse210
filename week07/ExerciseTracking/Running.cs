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

        public float CalculateSpeed()
        {
            return (_distance / (_duration / 60f));
        }

        public float CalculatePace()
        {
            return (_duration / _distance);
        }
    }
}