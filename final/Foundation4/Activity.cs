
abstract class Activity
{
    private DateTime _date;
    private int _durationInMinutes;

    public Activity(DateTime date, int durationInMinutes)
    {
        _date = date;
        _durationInMinutes = durationInMinutes;
    }

    public int GetDuration()
    {
        return _durationInMinutes;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public abstract double GetDistance(); // Distance in miles
    public abstract double GetSpeed(); // Speed in mph
    public abstract double GetPace(); // Pace in min per mile
    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_durationInMinutes} min): Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min/mile";
    }
}