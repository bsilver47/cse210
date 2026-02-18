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
    }
}