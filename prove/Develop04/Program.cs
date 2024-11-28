using System;

class Program
{
    static void Main(string[] args)
    {
        string menuChoice;
        string[] menuOptions = {"1","2","3"};
        List<int> activitiesCompleted = new List<int>{0,0,0};
        Activity preActivity = new Activity();

        do
        {
            preActivity.DisplayMenu();
            Console.Write("\nSelect a choice from the menu: ");
            menuChoice = Console.ReadLine();
            Activity activity = new Activity(menuChoice, activitiesCompleted);
            if (menuOptions.Contains(menuChoice))
            {
                activitiesCompleted = activity.BeginActivity();
            }
            else if(menuChoice != "4")
            {
                Console.WriteLine("\n<Invalid Input>\n");
            }

        }while(menuChoice != "4");

        

        
    }
}