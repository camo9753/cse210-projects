public class Listing : Activity
{
    private string _startLMessage = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private string _endLMessage = "Great Job!!";
    private int _itemCount = 0;
    private List<string> _listingPrompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"};

    public Listing(string menuChoice, List<int> activitiesCompleted) : base(menuChoice, activitiesCompleted){}
    public void ListingExercise()
    {
        DisplayAStartMessage();
        DisplayLStartMessage();
        int timeDuration = GetTimeDuration();

        Console.Clear();
        Console.WriteLine("Get ready...");
        PauseApp(4);

        Console.WriteLine("\nList as many responses you can to the following prompt:");
        int randomListInt = _random.Next(0, _listingPrompts.Count);
        Console.WriteLine($"--- {_listingPrompts[randomListInt]} ---");
        Console.Write("\nYou may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timeDuration);
        Console.WriteLine();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _itemCount += 1;
        }
        Console.WriteLine($"You listed {_itemCount} items!");

        DisplayLEndMessage();
        PauseApp(4);
        DisplayAEndMessage(timeDuration);
        PauseApp(4);
    }
    public void DisplayLStartMessage()
    {
        Console.WriteLine($"\n{_startLMessage}");
    }
    public void DisplayLEndMessage()
    {
        Console.WriteLine($"\n\n{_endLMessage}");
    }
}
