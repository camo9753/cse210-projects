using System;

class EternalGoal : Goal
{
    public EternalGoal(int pointTotal, List<string[]> goalList) : base(pointTotal, goalList){}
    public void CreateEternalGoal(string type)
    {
        SetNewGoal(type);
    }

}