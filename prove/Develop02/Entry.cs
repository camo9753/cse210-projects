using System.Dynamic;

public class Entry
{
    private List<string> _prompts = new List<string> 
        {"Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What are a few blessings you saw throughout your day?",
        "Describe any meaningful dates you have been on lately?"};
    public string _date;
    private string _userInput;
    Random _random = new Random();

    public string CreateEntry()
    {
        string date = GetTime();
        string randomPrompt = DisplayPrompt();
        string userInput = GetInput();
        string userEntry = $"Date: {date} - Prompt: {randomPrompt}\n{userInput}";
        return userEntry;
    }
    
    public string GetTime()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        return _date;
    }

    public string GetInput()
    {
        _userInput = Console.ReadLine();
        return _userInput;
    }
    
    public string DisplayPrompt()
    {
        int randomIndex = _random.Next(7);
        string randomPrompt = _prompts[randomIndex];
        Console.WriteLine($"{randomPrompt}");
        return randomPrompt;
    }
}

