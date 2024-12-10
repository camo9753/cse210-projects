using System;

class SimpleGoal : Goal
{
    

    public SimpleGoal(int pointTotal, List<string[]> goalList) : base(pointTotal, goalList){}
    public void CreateSimpleGoal(string type)
    {
        SetNewGoal(type);
    }

}