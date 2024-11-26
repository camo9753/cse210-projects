using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment parent = new Assignment("Joseph Smith", "Multiplication");
        Console.WriteLine(parent.GetSummary());

        MathAssignment child1 = new MathAssignment("Brigham Young", "Fractions", "7.3", "8-19");
        Console.WriteLine(child1.GetSummary());
        Console.WriteLine(child1.GetHomeworkList());

        WritingAssignment child2 = new WritingAssignment("Martin Harris", "European History", "The Causes of World War II");
        Console.WriteLine(child2.GetSummary());
        Console.WriteLine(child2.GetWritingInfo());
    }
}