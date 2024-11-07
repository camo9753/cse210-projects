using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int num;
        List<int> numbers = new List<int>();
        Console.WriteLine("[Enter a list of numbers, type 0 when finished]");
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
        double smallestPos = double.PositiveInfinity;
        double avg;
        foreach (int number in numbers)
        {
            sum = sum + number;
            if (num > largest)
            {
                largest = num;
            }
            if (number < smallestPos && number > 0)
            {
                smallestPos = number;
            }
        }
        avg = sum / (numbers.Count);
        numbers.Sort();

        Console.WriteLine($"Sum: {sum}\nAverage: {avg}\nLargest Number: {largest}\nSmallest Postive Number: {smallestPos}");
        Console.WriteLine("The sort list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}