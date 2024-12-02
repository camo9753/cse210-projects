public class Activity
{
    private string _menuChoice;
    private List<string> _activityList = new List<string>{"Breathing","Reflection","Listing"};
    private List<int> _activitiesCompleted = new List<int>();
    public Random _random = new Random();
    
    // This is to initalize the list for the completed activities list
    public Activity(List<int> activitiesCompleted)
    {
        _activitiesCompleted = activitiesCompleted;
    }
    public Activity(string menuChoice, List<int> activitiesCompleted)
    {
        _menuChoice = menuChoice;
        _activitiesCompleted = activitiesCompleted;
    }
    
    public int GetTimeDuration()
    {
        Console.Write("\nHow many seconds would you like to perform this activity for: ");
        string userTime = Console.ReadLine();
        int timeDuration = int.Parse(userTime);

        // time is returned in <int> seconds
        return timeDuration;
    }
    public void DisplayAStartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityList[int.Parse(_menuChoice) - 1]} activity!");
    }
    public void DisplayAEndMessage(int time)
    {
        Console.WriteLine($"You have completed {time} seconds of the {_activityList[int.Parse(_menuChoice) - 1]} activity!");
    }
    public void PauseApp(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < futureTime)
        {
            Console.Write("\\");
            Thread.Sleep(100);
            Console.Write("\b \b"); 
            Console.Write("|"); 
            Thread.Sleep(100);
            Console.Write("\b \b"); 
            Console.Write("/"); 
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("—");
            Thread.Sleep(100);
            Console.Write("\b \b");
        }
    }
    public void DisplayMenu()
    {
        // Displays Menu with number of completed tasks for each, including the total
        int sum = 0;
        foreach(int num in _activitiesCompleted)
        {
            sum += num;
        }

        Console.WriteLine($"\nMenu Options [{sum}]:");
        for (int i = 0; i < _activityList.Count; i++)
        {
            Console.WriteLine($"  {i+1}. [{_activitiesCompleted[i]}] {_activityList[i]} Activity");
        }
        Console.WriteLine("  4. Quit");
    }
    public List<int> BeginActivity()
    {
        if (_menuChoice == "1")
        {
            Breathing breathing = new Breathing(_menuChoice,_activitiesCompleted);
            breathing.BreathingExercise();
            _activitiesCompleted[0] += 1; 
        }
        else if(_menuChoice == "2")
        {
            Reflection reflection = new Reflection(_menuChoice,_activitiesCompleted);
            reflection.ReflectionExercise();
            _activitiesCompleted[1] += 1;
        }
        else if(_menuChoice == "3")
        {
            Listing listing = new Listing(_menuChoice,_activitiesCompleted);
            listing.ListingExercise();
            _activitiesCompleted[2] += 1;
        }
        return _activitiesCompleted;
    }
}