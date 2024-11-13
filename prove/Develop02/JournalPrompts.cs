public class Prompts
{
    public string _prompt1;
    public string _prompt2;
    public string _prompt3;
    public string _prompt4;
    public string _prompt5;
    
    public void InputPrompts()
    {
        Console.WriteLine("Who was the most interesting person I interacted with today? ");
        string _prompt1 = Console.ReadLine();

        Console.WriteLine("What was the best part of my day? ");
        string _prompt2 = Console.ReadLine();

        Console.WriteLine("How did I see the hand of the Lord in my life today? ");
        string _prompt3 = Console.ReadLine();

        Console.WriteLine("What was the strongest emotion I felt today? ");
        string _prompt4 = Console.ReadLine();

        Console.WriteLine("If I had one thing I could do over today, what would it be? ");
        string _prompt5 = Console.ReadLine();
    }
}