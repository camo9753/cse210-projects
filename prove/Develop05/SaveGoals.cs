using System;

class SaveGoals : Goal
{

    public void SaveGoalsToFile()
    {
        _goalList = GetGoalList();

        if (_fileName == null)
        {
            FileNotFound();
        }
        else
        {
            using (StreamWriter outputFile = new StreamWriter(_fileName))
            {
                foreach (string[] goal in _goalList)
                {
                    outputFile.WriteLine(goal);
                }
            }
        }
    }
    public void FileNotFound()
    {
        Console.WriteLine("<There is no file loaded to the program>");
    }
}