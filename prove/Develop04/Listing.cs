public class Listing : Activity
{
    private string _startLMessage = "This is the intro listing message.";
    private string _endLMessage = "This in the ending listing message.";

    public Listing() : base()
    {

    }
    public void ListingExercise()
    {
        Console.WriteLine("Testing Listing");
    }
    public string DisplayBStartMessage()
    {
        return _startLMessage;
    }
    public string DisplayBEndMessage()
    {
        return _endLMessage;
    }
}
