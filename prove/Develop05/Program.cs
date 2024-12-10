using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        ListGoals listGoals = new ListGoals();
        SaveGoals saveGoals = new SaveGoals();
        LoadGoals loadGoals = new LoadGoals();

        List<string> choiceList = new List<string> {"1","2","3","4","5","6","7"};
        string CreateNewGoal = "1";
        string ListGoals = "2";
        string SaveGoals = "3";
        string LoadGoals = "4";
        string EditGoal = "5";
        string RecordEvent = "6";
        string Quit = "7";

        menu.DisplayMenu();
        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();

        while (choice != Quit)
        {
            if (choice == CreateNewGoal)
            {

            }
            else if (choice == ListGoals)
            {
                listGoals.ListUserGoals();
            }
            else if (choice == SaveGoals)
            {
                saveGoals.SaveGoalsToFile();
            }
            else if (choice == LoadGoals)
            {
                loadGoals.SetFileName();
                loadGoals.SetGoalList();
            }
            else if (choice == EditGoal)
            {

            }
            else if (choice == RecordEvent)
            {

            }
            else if (!choiceList.Contains(choice))
            {
                Console.WriteLine("<Invalid Input>");
            }
        }
        

    }
}