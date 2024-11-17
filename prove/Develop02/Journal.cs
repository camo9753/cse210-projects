using System;
using System.IO;

public class Journal
{
    public List<string> _entries = new List<string> {};
    


    public void DisplayAllEntries()
    {
        Console.WriteLine();
        foreach (string entry in _entries)
        {
            Console.WriteLine(entry);
        }
    } 

    public void SaveEntriesToFile(string file)
    {
        // string file = _menu._fileName;
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (string entry in _entries)
            {
                outputFile.Write(entry);
            }
        }
        _entries.Clear();
    }

    public void ReadEntriesFromFile(string file)
    {
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
        int entryCount = _entries.Count();
        Console.WriteLine($"\n<Entry was added to your que. Entries in que:[{entryCount}]>");
    }
}