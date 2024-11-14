using System.Dynamic;

public class Entry
{
    public string _prompts;
    public string _date;
    public string _userInput;

    public string GetTime()
    {
        DateTime theCurrentTime = DateTime.Now;
        string _date = theCurrentTime.ToShortDateString();
        return _date;
    }

    // public string GetInput()
    // {

    // }

    public void CreateEntry()
    {
        string date = GetTime();
        Console.WriteLine(date);
    }

    // public string DisplayPrompt();
    // {

    // }

}

