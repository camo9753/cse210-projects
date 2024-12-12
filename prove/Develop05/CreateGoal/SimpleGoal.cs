using System;

class SimpleGoal : Goal
{
    

    public SimpleGoal(int pointTotal) : base(pointTotal){}
    public void CreateSimpleGoal(string type)
    {
        SetNewGoal(type);
    }
    public override int RecordEvent()
    {
        return GetPoints();
    }
}