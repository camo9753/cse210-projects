using System;

class Program
{
    static void Main(string[] args)
    {
        // Create activities
        Running running = new Running(DateTime.Now, 30, 3.0); // 3 miles in 30 minutes
        Cycling cycling = new Cycling(DateTime.Now.AddDays(-1), 45, 15.0); // 15 mph for 45 minutes
        Swimming swimming = new Swimming(DateTime.Now.AddDays(-2), 25, 20.0); // 20 laps in 25 minutes

        // Store activities in a list
        List<Activity> activityList = new List<Activity> {running, cycling, swimming};

        // Display summaries
        Console.WriteLine();
        foreach (Activity activity in activityList)
        {
            Console.WriteLine(activity.GetSummary());
        }
        Console.WriteLine();
    }
}