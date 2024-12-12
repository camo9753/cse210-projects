using System;

class Program
{
    static void Main(string[] args)
    {   
        List<Goal> goalList = new List<Goal>();
        int pointTotal = 0;
        // Goal goal = new Goal(pointTotal, goalList);
        Menu menu = new Menu(pointTotal);

        List<string> choiceList = new List<string> {"1","2","3","4","5","6","7"};
        
        string CreateNewGoal = "1";
        string ListGoals = "2";
        string SaveGoals = "3";
        string LoadGoals = "4";
        string EditGoal = "5";
        string RecordEvent = "6";
        string Quit = "7";

        string Simple = "Simple";
        string Eternal = "Eternal";
        string Checklist = "Checklist";

        menu.DisplayMenu();
        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();

        // Start of Program loop
        while (choice != Quit)
        {
            if (choice == CreateNewGoal)
            {
                
                menu.DisplayGoalOptions();
                // string goalType = goal.SetGoalType(); 
                int selection = int.Parse(Console.ReadLine());
                if (selection == 1)
                {
                    SimpleGoal simpleGoal = new SimpleGoal(pointTotal);
                    simpleGoal.CreateSimpleGoal("Simple");
                    goalList.Add(simpleGoal);
                }
                // else if (goalType == Eternal)
                // {
                //     EternalGoal eternalGoal = new EternalGoal(pointTotal, goalList);
                //     eternalGoal.CreateEternalGoal(goalType);
                // }
                // else if (goalType == Checklist)
                // {
                //     ChecklistGoal checklist = new ChecklistGoal(pointTotal, goalList);
                //     checklist.CreateChecklistGoal(goalType);
                // }
                // goalList = goal.GetGoalList();
                Console.WriteLine("\n<Goal has been created>");

            }
            else if (choice == ListGoals)
            {
                foreach (Goal goal in goalList)
                {
                    goal.DisplayGoal();
                }
            }
            // else if (choice == SaveGoals)
            // {
            //     SaveGoals saveGoals = new SaveGoals(pointTotal, goalList);
            //     saveGoals.SaveGoalsToFile();
            // }
            // else if (choice == LoadGoals)
            // {
            //     LoadGoals loadGoals = new LoadGoals(pointTotal, goalList);
            //     loadGoals.SetFileName();
            //     loadGoals.SetGoalList();
            // }
            else if (choice == EditGoal)
            {

            }
            else if (choice == RecordEvent)
            {
                foreach (Goal goal in goalList)
                {
                    pointTotal += goal.GetPoints();
                }
                
            }
            else if (!choiceList.Contains(choice))
            {
                Console.WriteLine("<Invalid Input>");
            }

            // Menu postMenu = new Menu(pointTotal, goalList);
            menu.DisplayMenu();
            Console.WriteLine($"Total Points: {pointTotal}");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
        }
    }
}