using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction get = new Fraction();
        int top = get.GetTop();
        int bottom = get.GetBottom();

        Fraction f1 = new Fraction(top,bottom);
        Console.WriteLine("\nFraction:");
        Display(f1.GetFractionString(), f1.GetDecimalValue());

        // Fraction.GetTop();
        // Fraction f2 = new Fraction(5);
        // Console.WriteLine("\nF2(5):");
        // Display(f2.GetFractionString(), f2.GetDecimalValue());

        // Fraction f3 = new Fraction(3,4);
        // Console.WriteLine("\nF3(3,4):");
        // Display(f3.GetFractionString(), f3.GetDecimalValue());

        // Fraction f4 = new Fraction(1,3);
        // Console.WriteLine("\nF4(1,3):");
        // Display(f4.GetFractionString(), f4.GetDecimalValue());

        // Fraction f5 = new Fraction(5,8);
        // Console.WriteLine("\nF5(5,8):");
        // Display(f5.GetFractionString(), f5.GetDecimalValue());
    }

    static void Display(string fraction, double deci)
    {
        Console.WriteLine($"Fraction: {fraction}\nDecimal: {deci}");
    }
}