using System;

class Program
{
    static void Main(string[] args)
    {

    // Generates a random number for user to guess
    Random randomGenerator = new Random();
    int randomNumber = randomGenerator.Next(1, 100);  
    int number;
    int count = 0;
    do
        {
        Console.Write("Guess a number between 1 and 100: ");
        number = int.Parse(Console.ReadLine());
        count++;
        if (number > randomNumber)
            {
            Console.WriteLine("Lower");
            }
        else if (number < randomNumber)
            {
            Console.WriteLine("Higher");
            }   
        }while(number != randomNumber);

    Console.WriteLine($"Your guess of '{number}' is correct with the random number equaling ({randomNumber})");
    Console.WriteLine($"You took {count} attempts.");
    }
}