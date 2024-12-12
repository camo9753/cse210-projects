using System;
    // type = goal[0];
    // name = goal[1];
    // discription = goal[2];
    // points = goal[3];
    // frequency = goal[4];
    // bonusPoints = goal[5];
    // strStatus = goal[6];
    // frequencyCompleted = goal[7];

class ChecklistGoal : Goal
{
    public ChecklistGoal(int pointTotal) : base(pointTotal){}


    public void CreateChecklistGoal(string type)
    {
        SetNewGoal(type);
    }
    public override void SetNewGoal(string goalType)
    {
        // _goal[0] = goalType;
        // _goal[1] = SetGoalName();
        // _goal[2] = SetGoalDiscription();
        // _goal[3] = SetGoalPointAmount();
        // _goal[4] = SetGoalFrequency();
        // _goal[5] = SetBonusPoints();
        // _goal[6] = "false";
        // _goal[7] = "0";

        // SetGoalList();
    }
    public override int RecordEvent()
    {
        return 0;
    }

}