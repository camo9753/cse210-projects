public class Activity
{
    private string _menuChoice;
    private List<string> _activityList = new List<string>{"Breathing","Reflection","Listing"};
    private List<int> _activitiesCompleted = new List<int>{};

    public Activity(){}
    public Activity(string menuChoice, List<int> activitiesCompleted)
    {
        _menuChoice = menuChoice;
        _activitiesCompleted = activitiesCompleted;
    }
    public int GetTimeDuration()
    {
        Console.Write("How many seconds would you like to perform this activity for: ");
        string userTime = Console.ReadLine();
        int _timeDuration = int.Parse(userTime) * 1000;

        // time is returned in milliseconds
        return _timeDuration;
    }
    public string DisplayAStartMessage()
    {
        string _startAMessage = $"Welcome to the {_activityList[int.Parse(_menuChoice) - 1]} activity!";
        return _startAMessage;
    }
    public string DisplayAEndMessage()
    {
        string _endAMessage = $"You have completed the {_activityList[int.Parse(_menuChoice) - 1]} activity!";
        return _endAMessage;
    }
    public void PauseApp()
    {

    }
    public void DisplayMenu()
    {
        // calculates total number of activities completed
        int _totalActivityCount = 0;
        foreach (int num in _activitiesCompleted)
        {
            _totalActivityCount += num;
        }

        // Displays Menu with number of completed tasks for each, plus the total
        Console.WriteLine("Menu Options:");
        for (int i = 0; i < _activityList.Count; i++)
        {
            Console.WriteLine($"  {i+1}. {_activityList[i]} [{_activitiesCompleted[i]}]");
        }
        Console.WriteLine("  4. Quit");
        Console.WriteLine($"  <Total activities completed [{_totalActivityCount}]>");
    }
    public List<int> BeginActivity()
    {
        if (_menuChoice == "1")
        {
            Breathing breathing = new Breathing();
            breathing.BreathingExercise();
            _activitiesCompleted[0] += 1; 
        }
        else if(_menuChoice == "2")
        {
            Reflection reflection = new Reflection();
            reflection.ReflectionExercise();
            _activitiesCompleted[1] += 1;
        }
        else if(_menuChoice == "3")
        {
            Listing listing = new Listing();
            listing.ListingExercise();
            _activitiesCompleted[2] += 1;
        }
        return _activitiesCompleted;
    }
}