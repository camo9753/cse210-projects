using System;

class Program
{
    class Circle
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double GetDiameter()
        {
            return radius * 2;
        }

        public double GetCircumference()
        {
            return radius * 2 * Math.PI;
        }

        public double GetRadius()
        {
            return radius;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public void Display()
        {
            Console.WriteLine($"Area: {GetArea()}");
            Console.WriteLine($"Radius: {GetRadius()}");
            Console.WriteLine($"Circumference: {GetCircumference()}");

        }
    }

    public static void Main(string[] args)
    {
        int x = 10;
        Circle myCircle = new Circle(x);
        Circle myCircle2 = new Circle(x + 2);

        myCircle.Display();





        // int x = 10;
        // int y = x++;
        // Console.WriteLine($"{y}, {x}");
        
        // int z = ++y;
        // Console.WriteLine($"{z}, {y}");

        // int total = AddNumbers(20,30);
        // Console.WriteLine(total);


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