public class Breathing : Activity
{
    private string _startBMessage = "This activity will help you realz by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    private string _endBMessage = "Well Done!!";

    public Breathing(string menuChoice, List<int> activitiesCompleted) : base(menuChoice, activitiesCompleted){}
    public void BreathingExercise()
    {
        Console.Clear();
        DisplayAStartMessage();
        DisplayBStartMessage();
        int timeDuration = GetTimeDuration();
        
        Console.Clear();
        Console.WriteLine("Get ready...");
        PauseApp(4);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timeDuration);
        while (DateTime.Now < endTime)
        {
            Console.Write("\n\nBreathe in...");
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.Write("\nNow breathe out...");
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        DisplayBEndMessage();
        PauseApp(4);

        DisplayAEndMessage(timeDuration);
        PauseApp(4);
    }
    public void DisplayBStartMessage()
    {
        Console.WriteLine($"\n{_startBMessage}");
    }
    public void DisplayBEndMessage()
    {
        Console.WriteLine($"\n{_endBMessage}");    
    }
}