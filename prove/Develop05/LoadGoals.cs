using System;

class LoadGoals
{
    public LoadGoals(int pointTotal){}
    public void SetFileName()
    {
        Console.Write("Enter the file name you wish to edit/add future goals to: ");
        string _fileName = Console.ReadLine();        
    }
    // public override List<string[]> SetGoalList()
    // {
    //     string[] file = System.IO.File.ReadAllLines(_fileName);

    //     if (new FileInfo(_fileName).Length == 0)
    //     {
    //         Console.WriteLine($"The file [{_fileName}] is currently empty.");
    //     }
    //     else 
    //     {
    //         foreach (string line in file)
    //         {
    //             string[] goal = line.Split(",");

    //             string type = goal[0];
    //             string name = goal[1];
    //             string discription = goal[2];
    //             string frequency = goal[3];
    //             string points = goal[4];
    //             string bonusPoints = goal[5];
    //             string status = goal[6];

    //             _goalList.Add(goal);
    //         }
    //         Console.WriteLine($"<Goals have been extracted from [{_fileName}]>");
    //     }
    //     return _goalList;
    // }
}