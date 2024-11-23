using System;

class Program
{
    
    static void Main(string[] args)
    {
        Reference getR = new Reference();
        List<string> scripture = getR.GetReference();
        Reference inputScripture = new Reference(scripture[0],scripture[1]);
        string reference = inputScripture.SetReference();
        string referenceText = inputScripture.SetReferenceText();
        Console.Clear();

        Console.WriteLine(reference + " - " + referenceText);
        Console.Write("\nPress ENTER to continue or type 'q' to quit: ");
        string choice = Console.ReadLine();

        Scripture getS = new Scripture(referenceText);
        List<string> wordList = getS.GetWordList();
        int usedIndices = getS.GetUsedIndices();
        
        
        while (choice != "q")
        {
            if (usedIndices == wordList.Count)
            {
                Console.WriteLine("\nStill having trouble? Simply run the program again.\n");
                Environment.Exit(1);
            }
            else
            {
                Console.Clear();
                string hiddenScripture = getS.RemoveRandomWords(wordList);
                Console.WriteLine(reference + " - " + hiddenScripture);
                Console.Write("\nPress ENTER to continue or type 'q' to quit: ");
                choice = Console.ReadLine();
                usedIndices = getS.GetUsedIndices();
            }
        }

        Console.WriteLine("Better Luck Next Time!");
        
        
    }
}