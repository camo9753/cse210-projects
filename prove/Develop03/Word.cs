using System;

class Word
{
    private string _word;
    private string _underscoreWord = "";
    private List<char> _ignoredChars = new List<char>();

    public Word(string word)
    {
        _word = word;  
        _ignoredChars.AddRange(new char[] {',',';',':','_','-'});
    }
    public string GetWord(string word)
    {
        string hideToWord = word;
        return hideToWord;
    }
    public string HideWord(string hideToWord)
    {
        for(int i = 0; i < hideToWord.Length; i++)
        {
            if (!_ignoredChars.Contains(hideToWord[i]))
            {
                _underscoreWord = _underscoreWord + '_';
            }
            else
            {
                _underscoreWord = _underscoreWord + hideToWord[i];
            }
        } 
        return _underscoreWord;
    }
}