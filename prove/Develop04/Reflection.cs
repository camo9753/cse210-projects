public class Reflection : Activity
{
    private string _startRMessage = "This is the intro reflection message.";
    private string _endRMessage = "This in the ending reflection message.";

    public Reflection() : base()
    {

    }
    public void ReflectionExercise()
    {
        Console.WriteLine("Testing Reflection");

    }
    public string DisplayBStartMessage()
    {
        return _startRMessage;
    }
    public string DisplayBEndMessage()
    {
        return _endRMessage;
    }
}