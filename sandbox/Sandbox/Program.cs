using System;

class Program
{
    static int AddNumbers(int n1, int n2)
    {
        int total = n1 + n2;
        int total2 = n1 * n2;
        return total2;
    }

    public static void Main(string[] args)
    {
        int total = AddNumbers(20,30);
        Console.WriteLine(total);


        // for(int i=0; i<10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // int age = -1;
        // while(age < 0 || age > 120)
        // {
        //     Console.Write("Please enter your age (0-125): ");
        //     age = int.Parse(Console.ReadLine());
        //     Console.WriteLine($"Your age is: {age}");
        // }

        // int age;
        // do
        // {
        //     Console.Write("Please enter your age (0-125): ");
        //     age = int.Parse(Console.ReadLine());
        //     Console.WriteLine($"Your age is: {age}");
        // }while(age < 0 || age > 120);


        // List <string> myColors = new List<string>();
        // myColors.Add("Blue");
        // myColors.Add("Red");
        // myColors.Add("Green");
        // foreach(string color in myColors)
        // {
        //     Console.WriteLine(color);
        // }

    }
}