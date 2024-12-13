class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int durationInMinutes, double speed) : base(date, durationInMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetDuration()) / 60;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
}