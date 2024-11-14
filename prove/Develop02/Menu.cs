using System;


public class Menu
{
    private List<string> _menuOptions;
    private int _menuChoice;

    public void DisplayMenu()
    {
        _menuOptions = new List<string> {"Write", "Display Entries", "Load", "Save", "Quit"};
        for (int i = 0; i < _menuOptions.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_menuOptions[i]}");
        }
    }

    public void Write()
    {

    }

    static void Display()
    {
        Console.WriteLine("1. Display Recent Entry(s)\n2. Display File Entry");
        string display2Index = Console.ReadLine();
        int display2 = int.Parse(display2Index);

        if (display2 == 1)
        {

        }

    }

    public string LoadFile()
    {
        string fileName = "Journal.txt";
        Console.WriteLine($"File [{fileName}] has been loaded to the program.");
        return fileName;
        
    }

    static void Save()
    {

    }


    public void UserSelect()
    {
        
        do
        {
            DisplayMenu();
            string menuChoice = Console.ReadLine();
            _menuChoice = int.Parse(menuChoice);

            if (_menuChoice == 1)
                {
                    Write();
                }
            else if (_menuChoice == 2)
                {
                    Display();
                }
            else if (_menuChoice == 3)
                {
                    LoadFile();
                }
            else if (_menuChoice == 4)
                {
                    Save();
                }
            else if (_menuChoice != 5)
                {
                    Console.WriteLine("<Sorry, Please Type Invalid Menu Choice>");
                }
        }while(_menuChoice != 5);

    }
}   
