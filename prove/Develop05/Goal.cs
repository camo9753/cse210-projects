using System;
    
    // type = goal[0];
    // name = goal[1];
    // discription = goal[2];
    // points = goal[3];
    // frequency = goal[4];
    // bonusPoints = goal[5];
    // strStatus = goal[6];
    // frequencyCompleted = goal[7];

class Goal
{
    Menu menu = new Menu();
    protected string _fileName;
    protected List<string[]> _goalList;
    private List<string> _goal;
    private int _pointTotal;
 
    public virtual void SetNewGoal()
    {
        _goal[0] = SetGoalType();
        _goal[1] = SetGoalName();
        _goal[2] = SetGoalDiscription();
        _goal[3] = SetGoalPointAmount();
        _goal[4] = "0";
        _goal[5] = "0";
        _goal[6] = "false";
        _goal[7] = "0";

        SetGoalList();
    }
    public List<string[]> GetGoalList() 
    {
        return _goalList;
    }
    public virtual void SetGoalList()
    {
        _goalList.Add(_goal.ToArray());
    }
    public void DisplayGoals()
    {
        if (GetGoalList().Count == 0)
        {
            Console.WriteLine($"There are no goals currently qequed.");
        }
        else
        {
            int count = 1;
            foreach (string[] goal in GetGoalList())
            {
                string type = goal[0];
                string name = goal[1];
                string discription = goal[2];
                string points = goal[3];
                string frequency = goal[4];
                string bonusPoints = goal[5];
                string strStatus = goal[6];
                string frequencyCompleted = goal[7];

                bool status = bool.Parse(strStatus);
                if (status == true)
                {
                    strStatus = "[X]";
                }
                else
                {
                    strStatus = "[ ]";
                }


                if (frequency == "0")
                {
                    Console.WriteLine($"{count}. {strStatus} {name}-({discription})");
                }
                else
                {
                    Console.WriteLine($"{count}. {strStatus} {name}-({discription}) -- Currently completed: {frequencyCompleted}/{frequency}");
                }
                
                count = count++;
            }
        }
    }

    public string SetGoalType()
    {
        string goalType = "";
        string goalInt;
        
        do
        {
            menu.DisplayGoalOptions();
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
        }while(!new[] {"1","2","3"}.Contains(goalInt));
    
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
    public string SetGoalPointAmount()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        string pointGoal = Console.ReadLine();
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

}