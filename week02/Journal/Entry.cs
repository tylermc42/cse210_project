using System;

public class Entry
{
    //variables
    public string _date;
    public string _promptText;
    public string _entryText;

    //method
    public void Display()
    {
        Console.WriteLine($"[{_date}] | {_promptText} |\nResponse: {_entryText}\n");
    }
}

