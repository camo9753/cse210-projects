using System;


class Scripture
{
    private List<int> _usedIndices = new List<int>();
    private string _scriptureString;
    private Random _random = new Random();
    public Scripture(string referenceText)
    {
        _scriptureString = referenceText;
    }
    public int GetUsedIndices()
    {
        return _usedIndices.Count;
    }
    public List<string> GetWordList()
    {
        List<string> wordList = _scriptureString.Split(" ").ToList();
        return wordList;
    }
    public HashSet<int> SelectIndices()
    {
        int maxIndex = GetWordList().Count();
        HashSet<int> randomIndexSet = new HashSet<int>();
        int picknum = FinalTest(GetWordList());
        while (randomIndexSet.Count() < picknum)
        {
            int randomIdex = _random.Next(0,maxIndex);
            if (!_usedIndices.Contains(randomIdex))
            {
                randomIndexSet.Add(randomIdex);
                _usedIndices.Add(randomIdex);
            } 
        }
    
    return randomIndexSet;  
    }
    public string RemoveRandomWords(List<string> wordList)
    {
        HashSet<int> randomIndexSet = SelectIndices();
        foreach (int index in randomIndexSet)
        {
            string hideWord = GetWordList()[index];
            Word getW = new Word(hideWord);
            string hiddenWord = getW.HideWord(hideWord);
            wordList[index] = hiddenWord;
        } 
        string hiddenScripture = DisplayScripture(wordList);
        return hiddenScripture;
    }
    private string DisplayScripture(List<string> wordList)
    {
        string hiddenScripture = "";
        foreach (string word in wordList)
        {
            hiddenScripture = hiddenScripture + word + " ";
        }
        return hiddenScripture;
    }
    private int FinalTest(List<string> wordList)
    {
        int picknum = 3;
        if (wordList.Count - _usedIndices.Count < 3)
        {
            picknum = 2;
        }
        if (wordList.Count - _usedIndices.Count < 2)
        {
            picknum = 1;
        }
        return picknum;

    }
}