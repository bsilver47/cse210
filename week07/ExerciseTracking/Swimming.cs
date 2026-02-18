namespace ExerciseTracking
{
    public class Swimming : Exercise
    {
        public Swimming(string name, int duration, DateOnly date, float laps) : base(name, duration, date)
        {
            _distance = laps * 50f / 1000f * 0.62f;
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