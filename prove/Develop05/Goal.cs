using System;
    
    // type = goal[0];
    // name = goal[1];
    // discription = goal[2];
    // points = goal[3];
    // frequency = goal[4];
    // bonusPoints = goal[5];
    // strStatus = goal[6];
    // frequencyCompleted = goal[7];

abstract class Goal
{
    protected string _fileName;
    // protected List<string[]> _goalList;
    protected List<string> _goal = new List<string> {"","","","","","","",""};
    private int _pointTotal;
    private string goalType;
    private string goalName;
    private string goalDiscription;
    private int points;
    private int maxNum;
    private int bonusPoints;
    private bool status;
    private int numCompleted;

 
    public Goal(){}
    public Goal(int pointTotal)
    {
        _pointTotal = pointTotal;
    }
    public virtual void SetNewGoal(string Type)
    {
        goalType = Type;
        goalName = SetGoalName();
        goalDiscription = SetGoalDiscription();
        points= SetGoalPointAmount();
        _goal[4] = "0";
        _goal[5] = "0";
        _goal[6] = "false";
        _goal[7] = "0";

        // SetGoalList();
    }
    // public List<string[]> GetGoalList() 
    // {
    //     return _goalList;
    // }
    // public virtual List<string[]> SetGoalList()
    // {
    //     _goalList.Add(_goal.ToArray());
    //     return _goalList;
    // }
    // public void DisplayGoals()
    // {
    //     if (_goalList.Count == 0)
    //     {
    //         Console.WriteLine($"There are no goals currently qequed.");
    //     }
    //     else
    //     {
    //         int count = 0;
    //         foreach (string[] goal in _goalList)
    //         {
    //             count++;
    //             string type = goal[0];
    //             string name = goal[1];
    //             string discription = goal[2];
    //             string points = goal[3];
    //             string frequency = goal[4];
    //             string bonusPoints = goal[5];
    //             string strStatus = goal[6];
    //             string frequencyCompleted = goal[7];

    //             bool status = bool.Parse(strStatus);
    //             if (status == true)
    //             {
    //                 strStatus = "[X]";
    //             }
    //             else
    //             {
    //                 strStatus = "[ ]";
    //             }


    //             if (frequency == "0")
    //             {
    //                 Console.WriteLine($"{count}. {strStatus} {name}-({discription})");
    //             }
    //             else
    //             {
    //                 Console.WriteLine($"{count}. {strStatus} {name}-({discription}) -- Currently completed: {frequencyCompleted}/{frequency}");
    //             }
                
                
    //         }
    //     }
    // }
    public void DisplayGoal()
    {
        Console.WriteLine($"[ ]{goalName} - {goalDiscription} - {points}");
    }
    public string SetGoalType()
    {
        string goalType = "";
        string goalInt;
        List<string> goalOptions = new List<string> {"1","2","3"};
        
        do
        {
            Console.Write("Which type of goal would you like to create? ");
            goalInt = Console.ReadLine();

            if (goalInt == "1")
            {
                goalType = "Simple";
            }
            else if(goalInt == "2")
            {
                goalType = "Eternal";
            }
            else if (goalInt == "3")
            {
                goalType = "Checklist";
            }
            else
            {
                Console.WriteLine("<Invalid input. Please enter a goal type>");
            }
        
        }while(!goalOptions.Contains(goalInt));
    
        return goalType;
    }
    public string SetGoalName()
    {
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        return goalName;
    }
    public string SetGoalDiscription()
    {
        Console.Write("What is a short discription of it? ");
        string goalDiscription = Console.ReadLine();
        return goalDiscription;
    }
    public int SetGoalPointAmount()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        int pointGoal = int.Parse(Console.ReadLine());
        return pointGoal;
    }
    public string SetGoalFrequency()
    {
        Console.Write("How many times does this goal need to be completed for a bonus (>1)? ");
        string goalFrequency = Console.ReadLine();
        return goalFrequency;
    }
    public string SetBonusPoints()
    {
        Console.Write("What is the bonus for accomplishing it that many times? ");
        string bonusPointGoal = Console.ReadLine();
        return bonusPointGoal;
    }

    public void SetPointTotal(int points)
    {
        _pointTotal += points;
    }
    public int GetPointTotal()
    {
        return _pointTotal;
    }
    public abstract int RecordEvent();

    public int GetPoints()
    {
        return points;
    }
    
}