using System;

class ListGoals : Goal
{
        public ListGoals(int pointTotal, List<string[]> goalList) : base(pointTotal, goalList){}

    public void ListUserGoals()
    {
        DisplayGoals();
    }
    
}