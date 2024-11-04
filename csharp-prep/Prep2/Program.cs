using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade precentage: ");
        string valueFromUser = Console.ReadLine();
        
        int x = int.Parse(valueFromUser);
        string letter;

        if (x >= 90)
        {
            letter = "A";
        }
        else if (x >= 80)
        {
            letter = "B";        
        }
        else if (x >= 70)
        {
            letter = "C";        
        }
        else if (x >= 60)
        {
            letter = "D";       
        }
        else
        {
            letter = "F";        
        }

        if ((letter == "A") || (letter == "B") || (letter == "C")){
            Console.WriteLine($"Congradulations! You passed the class with a {letter}");}
        else{
            Console.WriteLine($"You failed the class with a {letter}. Better luck next time.");}
        }
    }