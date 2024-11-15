using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome To Your Virtual Journal!");
        Menu menu = new Menu();
        menu.UserSelect();
    }
}