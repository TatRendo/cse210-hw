using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        entries.Add(new Entry(prompt, response));
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        entries.Clear();
        string[] lines = File.ReadAllLines(fileName);
        foreach (var line in lines)
        {
            var parts = line.Split('|');
            entries.Add(new Entry(parts[1], parts[2]) { Date = parts[0] });
        }
    }
}