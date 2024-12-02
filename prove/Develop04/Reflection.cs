public class Reflection : Activity
{
    private string _startRMessage = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private string _endRMessage = "Way to go!!";
    private List<string> _initialPrompts = new List<string>{
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."};
    private List<string> _reflectPrompts = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"};
    

    public Reflection(string menuChoice, List<int> activitiesCompleted) : base(menuChoice, activitiesCompleted){}
    public void ReflectionExercise()
    {
        DisplayAStartMessage();
        DisplayRStartMessage();
        int timeDuration = GetTimeDuration();

        Console.Clear();
        Console.WriteLine("Get ready...");
        PauseApp(4);

        Console.WriteLine("\nConsider the following prompt:");
        int randomInitialInt = _random.Next(0, _initialPrompts.Count);
        Console.WriteLine($"\n--- {_initialPrompts[randomInitialInt]} ---");
        Console.Write("\nWhen you have something in mind, press ENTER to continue. ");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("\nYou may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timeDuration);
        while (DateTime.Now < endTime)
        {
            int randomReflectInt = _random.Next(0, _reflectPrompts.Count);
            Console.Write($"\n> {_reflectPrompts[randomReflectInt]} ");
            PauseApp(10);
        }

        DisplayREndMessage();
        PauseApp(4);

        DisplayAEndMessage(timeDuration);
        PauseApp(4);
    }
    public void DisplayRStartMessage()
    {
        Console.WriteLine($"\n{_startRMessage}");
    }
    public void DisplayREndMessage()
    {
        Console.WriteLine($"\n\n{_endRMessage}");
    }
}