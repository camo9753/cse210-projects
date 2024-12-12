using System;
    // type = goal[0];
    // name = goal[1];
    // discription = goal[2];
    // points = goal[3];
    // frequency = goal[4];
    // bonusPoints = goal[5];
    // strStatus = goal[6];
    // frequencyCompleted = goal[7];
// class RecordEvent
// {
    // public RecordEvent(int pointTotal) : base(pointTotal){}

    // private int goalInt;
    // public void CompleteGoal(int goalInt)
    // {
    //     // string[] goal = GetGoalList()[goalInt];
    //     if (goal[6] == "false")
    //     {
    //         int points = int.Parse(goal[3]);
    //         int bonusPoints = int.Parse(goal[5]);
    //         int frequency = int.Parse(goal[4]);
    //         int frequencyCompleted = int.Parse(goal[7]);

    //         if (goal[0] == "Checklist")
    //         {
    //             frequencyCompleted ++;
    //             if (frequencyCompleted == frequency)
    //             {
    //                 goal[6] = "true";
    //                 SetPointTotal(bonusPoints);
    //             }
    //             goal[7] = frequencyCompleted.ToString();
    //             SetPointTotal(points);
    //         }
    //         if (goal[0] == "Eternal")
    //         {
    //             frequencyCompleted ++;
    //             goal[7] = frequencyCompleted.ToString();
    //             SetPointTotal(points);
    //         }
    //         if (goal[0] == "Simple")
    //         {
    //             goal[6] = "true";
    //             SetPointTotal(points);
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine("\n<This goal is already completed>");
    //     }
    // }
    // public int PickGoal()
    // {
    //     DisplayGoals();
    //     Console.Write("\nWhich goal did you accomplish? ");
    //     string strGoal = Console.ReadLine();
    //     goalInt = int.Parse(strGoal);
    //     return goalInt - 1;
    // }
// }