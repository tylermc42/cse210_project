using System;
using System.Formats.Asn1;
using System.IO;

//create journal class
public class Journal
{
    // variables
    public List<Entry> _entries = new List<Entry>();

    // methods
    // add entry
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);   
    }

    //display entries
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    //save to file
    // Don't forget to put 'using System.IO;' at the top, so C# knows where to find the StreamWriter class
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            // use foreach function to add each line to file
            foreach (var entry in _entries)
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine($"{entry._date} | Prompt: {entry._promptText}\n{entry._entryText}");
            }
        }
    }

    //load from file
    public void LoadFromFile(string file)
    {
        //read each line in file
        string[] lines = File.ReadAllLines(file);
        //iterate through each line and split it up at | symbol
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            //if line contains three parts, add the entry
            if (parts.Length == 3)
            {
                Entry loadedEntry = new Entry();
                loadedEntry._date = parts[0];
                loadedEntry._promptText = parts[1];
                loadedEntry._entryText = parts[3];
                _entries.Add(loadedEntry);
            }
        }
    }
}