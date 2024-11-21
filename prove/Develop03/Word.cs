using System;

class Word
{
    private string _word;
    private bool _isHidden;
    private string _underscoreWord;

    public Word(string word, bool isHidden, string underscoreWord)
    {
        _word = word;
        _isHidden = isHidden;
        _underscoreWord = underscoreWord;
    }
    public void GetWord()
    {

    }
    public string GetWord(string word)
    {
        return word;
    }
    public void HideWord()
    {

    }
    public bool CheckIfHidden(bool isHidden)
    {
        return isHidden;
    }
}