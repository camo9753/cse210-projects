using System;


public class Menu
{
    private List<string> _menuOptions;
    private int _menuChoice;
    public string _fileName;
    Journal journal = new Journal(); 
    

    public void DisplayMenu()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("[Choose an Index Option]");
        _menuOptions = new List<string> {"Write", "Display", "Load", "Save", "Quit"};
        for (int i = 0; i < _menuOptions.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_menuOptions[i]}");
        }
        Console.WriteLine("------------------------------");
    }

    public void Write()
    {
        
        Entry entry = new Entry();
        journal.QueEntries();
    }

    public void Display()
    {
        Console.WriteLine("\n[DISPLAY Sub-Menu]");
        Console.WriteLine("1. Display Recent Entry(s)\n2. Display File Entry");
        Console.Write("> ");
        string display2Index = Console.ReadLine();
        int display2 = int.Parse(display2Index);

        if (display2 == 1)
        {
            if (journal._entries.Count == 0)
            {
                Console.WriteLine("\n<There are no entries qued. Write a prompt to begin a que>");
            }
            else
            {
                journal.DisplayAllEntries();
            }
        }

        if (display2 == 2)
        {
            if (_fileName == null)
            {
                Console.WriteLine("\n<No file has been loaded to display, load a file and try again>");
            }
            else
            {
                journal.ReadEntriesFromFile(_fileName);
            }
            
        }
    }

    public string LoadFile()
    {
        Console.Write("\nInput file you wish to load your entries into (ex:'files.txt'): ");
        _fileName = Console.ReadLine();
        Console.WriteLine($"<File [{_fileName}] has been loaded into the program>\n");
        return _fileName;
    }

    public void Save()
    {
        if (_fileName == null)
        {
            Console.WriteLine("\n<No file loaded to save qued entries, load a file and try again>\n");
        }
        else
        {
            journal.SaveEntriesToFile(_fileName);
            Console.WriteLine($"<[{journal._entries.Count}] qued entries have been saved to [{_fileName}]>");
        }
    }

    public void UserSelect()
    {
        do
        {
            DisplayMenu();
            Console.Write("> ");
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
                    Console.WriteLine("<Input Not Recognized - Please Type Valid Menu Index>");
                }
        }while(_menuChoice != 5);

    }
}   
