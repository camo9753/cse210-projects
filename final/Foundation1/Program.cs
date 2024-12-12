using System;

// videos = videoDetails, commentAuthors, commentText

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        string again = "";
        while (again != "q")
        {
            Video video = new Video();
            video.CreateVideoDetails();
            videoList.Add(video);

            Console.Write("Press ENTER to create another video, otherwise press 'q' to quit & display video details: ");
            again = Console.ReadLine();
        }

        // instruction for displaying video details
        foreach (Video video in videoList)
        {
            List<string> videoDetails = video.GetVideoDetails();
            string title = videoDetails[0];
            string author = videoDetails[1];
            string videoLength = videoDetails[2];
            string commentNum = videoDetails[3];
            
            List<List<string>> comments = video.GetComments();
            List<string> commenterList = comments[0];
            List<string> commentList = comments[1];

            Console.WriteLine($"\nTitle: {title} | Author: {author} | Video Length: {videoLength}s | Comments: [{commentNum}]");
            Console.WriteLine("Comments:");
            for (int i = 0; i < comments.Count; i++)
            {
                string commenter = commenterList[i];
                string comment = commentList[i];
                Console.WriteLine($"    * {commenter} - {comment}");
            }
        }



    }
}