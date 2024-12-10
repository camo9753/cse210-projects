using System;

class Menu : Goal
{
    private List<string> _menuOptions = new List<string>{"Create New Goal","List Goals","Save Goals","Load Goals","Edit Goal","Record Event","Quit"};
    private List<string> _goalOptions = new List<string>{"Simple Goal","Eternal Goal","Checklist Goal"};
    public void DisplayMenu()
    {
        Console.WriteLine($"You have {GetPointTotal()} points");
        Console.WriteLine("\nMenu Options:");
        for (int i = 0; i < _menuOptions.Count; i++)
        {
            Console.WriteLine($"    {i+1}. {_menuOptions[i]}");
        }  
    }
    public void DisplayGoalOptions()
    {
        Console.WriteLine("\nGoal Options:");
        for (int i = 0; i < _goalOptions.Count; i++)
        {
            Console.WriteLine($"    {i+1}. {_goalOptions[i]}");
        } 
    }

    
}