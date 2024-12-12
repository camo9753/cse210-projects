class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int durationInMinutes, double distance) : base(date, durationInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / GetDuration()) * 60;
    }
    public override double GetPace()
    {
        return GetDuration() / _distance;
    }
}