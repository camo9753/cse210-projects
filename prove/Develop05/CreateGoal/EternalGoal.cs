using System;

class EternalGoal : Goal
{
    public EternalGoal(int pointTotal) : base(pointTotal){}
    public void CreateEternalGoal(string type)
    {
        SetNewGoal(type);
    }
    public override int RecordEvent()
    {
        return 0;
    }

}