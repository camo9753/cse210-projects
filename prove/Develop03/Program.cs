using System;

class Program
{
    static void Main(string[] args)
    {
        Reference getR = new Reference();
        string referenceText = getR.GetReference();

        Scripture getS = new Scripture(referenceText);
        List<string> wordList = getS.GetWordList();

        foreach (string word in wordList)
        {
            Console.WriteLine(word);
        }
        
    }
}