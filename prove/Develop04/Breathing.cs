public class Breathing : Activity
{
    private string _startBMessage = "This is the intro breathing message.";
    private string _endBMessage = "This in the ending breathing message.";

    public Breathing() : base()
    {

    }
    public void BreathingExercise()
    {
        Console.WriteLine("Testing Breathing");
    }
    public string DisplayBStartMessage()
    {
        return _startBMessage;
    }
    public string DisplayBEndMessage()
    {
        return _endBMessage;
    }
}