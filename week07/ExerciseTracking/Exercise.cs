namespace ExerciseTracking
{
    public class Exercise
    {
        protected string _name;
        protected int _duration;
        protected DateOnly _date;
        protected float _distance;
        protected float _speed;
        protected float _pace;

        public Exercise(string name, int duration, DateOnly date)
        {
            _name = name;
            _duration = duration;
            _date = date;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetDuration()
        {
            return _duration;
        }

        public float CalculateSpeed()
        {
            return (_distance / (_duration / 60f));
        }

        public float CalculatePace()
        {
            return (_duration / _distance);
        }

        public float CalculateDistance(float speed)
        {
            return (speed * (_duration / 60f));
        }

        public string Summary()
        {
            return $"{_date}: {_name} for {_duration} minutes - Distance: {_distance} miles, Speed: {_speed} mph, Pace: {_pace} min/mile";
        }
    }
}