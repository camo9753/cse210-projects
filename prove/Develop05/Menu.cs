using System;

class Menu
{
    private int _pointTotal;
    public Menu(int pointTotal)
    {
        _pointTotal = pointTotal;
    }

    private List<string> _menuOptions = new List<string>{"Create New Goal","List Goals","Save Goals","Load Goals","Edit Goal","Record Event","Quit"};
    private List<string> _goalOptions = new List<string>{"Simple Goal","Eternal Goal","Checklist Goal"};
    public void DisplayMenu()
    {
        Console.WriteLine($"You have {_pointTotal} points");
        Console.WriteLine("\nMenu Options:");
        for (int i = 0; i < _menuOptions.Count; i++)
        {
            Console.WriteLine($"    {i+1}. {_menuOptions[i]}");
        }  
    }
    public void DisplayGoalOptions()
    {
        Console.WriteLine("\nGoal Type Options:");
        for (int i = 0; i < _goalOptions.Count; i++)
        {
            Console.WriteLine($"    {i+1}. {_goalOptions[i]}");
        } 
    }

    
}