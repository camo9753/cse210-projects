using System;
using System.IO;

public class Journal
{
    private List<string> _entries;
    Menu _menu = new Menu();


    public void DisplayAllEntries()
    {
        foreach (string entry in _entries)
        {
            Console.WriteLine(entry);
        }
    } 

    public void SaveEntriesToFile()
    {
        string file = _menu.LoadFile();
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (string entry in _entries)
            {
                outputFile.WriteLine(entry);
            }
        }
        _entries = new List<string> {};
    }

    public void ReadEntriesFromFile()
    {
        string file = _menu.LoadFile();
        string[] lines = File.ReadAllLines(file);
        Console.WriteLine($"File Content:\n");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

    public void QueEntries()
    {
        Entry entry = new Entry();
        string recentEntry = entry.CreateEntry();
        _entries.Add(recentEntry);
    }
}