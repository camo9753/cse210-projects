using System;

class EditedGoal : Goal 
{
    private List<string> _editedGoal = new List<string>{"test","test1"};

    public List<string> EditGoal()
    {
        List<string> testList = _editedGoal;
        return testList;
    }
    
}