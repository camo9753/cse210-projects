using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int num;
        List<int> numbers = new List<int>();
        do
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            if (num != 0)
            {
                numbers.Add(num);
            }
        }while(num != 0);

        int largest = 0;
        int sum = 0;
        double avg;
        foreach (int number in numbers)
        {
            
            if (num > largest)
            {
                largest = num;
            }

        }
    }
}