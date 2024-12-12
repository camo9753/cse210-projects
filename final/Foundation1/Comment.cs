using System;

class Comment
{
    private string _commenter;
    private string _commentText;
    
    public void CreateComment()
    {
        Console.Write("What is the commenter's name: ");
        _commenter = Console.ReadLine();
        Console.Write("What is the commenter's comment: ");
        _commentText = Console.ReadLine();
    }
    public string GetAuthor()
    {
        return _commenter;
    }
    public string GetComment()
    {
        return _commentText;
    }
}