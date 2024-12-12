using System;
using System.Reflection.Metadata.Ecma335;

// _videoDetails {_title, _author, _videoLength, _commentNum}

class Video
{
    Comment comment = new Comment();
    private List<string> _videoDetails = new List<string>();
    private string _title;
    private string _author;
    private string _videoLength;
    private List<List<string>> _comments = new List<List<string>>();
    private List<string> _commenterList = new List<string>();
    private List<string> _commentList = new List<string>();
    private string _commentNum;

    public List<string> CreateVideoDetails()
    {
        Console.Write("What is the title for the video: ");
        _title = Console.ReadLine();
        Console.Write("What is the author for this video: ");
        _author = Console.ReadLine();
        Console.Write("How long is seconds is this video: ");
        _videoLength = Console.ReadLine();


        int commentCount = 0;
        string again = "";
        while (commentCount == 4 || again != "q")
        {
            comment.CreateComment();
            _commenterList.Add(comment.GetAuthor());
            _commentList.Add(comment.GetComment());

            commentCount++;
            if (commentCount != 4)
            {
                Console.Write("Press ENTER to create another comment, otherwise press 'q' to exit comment-creation for this video: ");
                again = Console.ReadLine();
            }
        }

        _comments.Add(_commenterList);
        _comments.Add(_commentList);
        _commentNum = GetCommentNum().ToString();

        _videoDetails.Add(_title);
        _videoDetails.Add(_author);
        _videoDetails.Add(_videoLength);
        _videoDetails.Add(_commentNum);

        return _videoDetails;
    }
    public int GetCommentNum()
    {
        int commentNum = _commentList.Count;
        return commentNum;
    }
    public List<List<string>> GetComments()
    {
        return _comments;
    }
    public List<string> GetVideoDetails()
    {
        return _videoDetails;
    }
 
}