using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);

        
        while (DateTime.Now < futureTime)
        {
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b \b"); 
            Console.Write("|"); 
            Thread.Sleep(200);
            Console.Write("\b \b"); 
            Console.Write("/"); 
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b \b");
        }
    }
}