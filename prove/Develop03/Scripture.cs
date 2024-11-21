using System;


class Scripture
{
    private List<Word> _words = new List<Word>();
    private string _scriptureString;
    private int _hiddenWordAmount;
    private Random _random = new Random();

    public Scripture(string referenceText)
    {
        _scriptureString = referenceText;
    }

    public List<string> GetWordList()
    {
        List<string> wordList = _scriptureString.Split(" ").ToList();
        return wordList;
    }

    public void ProcessWord(List<string> wordList)
    {
        
    }
    public void DisplayScripture()
    {

    }

    

}