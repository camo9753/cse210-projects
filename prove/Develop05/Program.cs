using System;

class Program
{
    static void Main(string[] args)
    {   

        
        List<string[]> goalList = new List<string[]>();
        int pointTotal = 0;
        Goal goal = new Goal(pointTotal, goalList);
        Menu preMenu = new Menu(pointTotal, goalList);

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

        preMenu.DisplayMenu();
        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();

        // Start of Program loop
        while (choice != Quit)
        {
            Menu menu = new Menu(pointTotal, goalList);
            if (choice == CreateNewGoal)
            {
                
                menu.DisplayGoalOptions();
                string goalType = goal.SetGoalType();
                if (goalType == Simple)
                {
                    SimpleGoal simpleGoal = new SimpleGoal(pointTotal, goalList);
                    simpleGoal.CreateSimpleGoal(goalType);
                }
                else if (goalType == Eternal)
                {
                    EternalGoal eternalGoal = new EternalGoal(pointTotal, goalList);
                    eternalGoal.CreateEternalGoal(goalType);
                }
                else if (goalType == Checklist)
                {
                    ChecklistGoal checklist = new ChecklistGoal(pointTotal, goalList);
                    checklist.CreateChecklistGoal(goalType);
                }
                goalList = goal.GetGoalList();
                Console.WriteLine("\n<Goal has been created>");

            }
            else if (choice == ListGoals)
            {
                ListGoals listGoals = new ListGoals(pointTotal, goalList);
                listGoals.ListUserGoals();
            }
            else if (choice == SaveGoals)
            {
                SaveGoals saveGoals = new SaveGoals(pointTotal, goalList);
                saveGoals.SaveGoalsToFile();
            }
            else if (choice == LoadGoals)
            {
                LoadGoals loadGoals = new LoadGoals(pointTotal, goalList);
                loadGoals.SetFileName();
                loadGoals.SetGoalList();
            }
            else if (choice == EditGoal)
            {

            }
            else if (choice == RecordEvent)
            {
                RecordEvent recordEvent = new RecordEvent(pointTotal, goalList);
                if (goal.GetGoalList().Count == 0)
                {
                    Console.WriteLine($"There are no goals currently qued.");
                }
                else
                {
                    int goalInt = recordEvent.PickGoal();
                    recordEvent.CompleteGoal(goalInt);
                    pointTotal = goal.GetPointTotal();
                }
                
            }
            else if (!choiceList.Contains(choice))
            {
                Console.WriteLine("<Invalid Input>");
            }

            Menu postMenu = new Menu(pointTotal, goalList);
            postMenu.DisplayMenu();
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
        }
    }
}