
class Swimming : Activity
{
    private double _laps;
    private const double _lapDistanceInMiles = (50.0 / 1000.0 * 0.62); // 50 meters converted to miles

    public Swimming(DateTime date, int durationInMinutes, double laps) : base(date, durationInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * _lapDistanceInMiles;
    }
    public override double GetSpeed()
    {
        return GetDistance() / GetDuration() * 60;
    }
    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }
}