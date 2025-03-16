using System;

public class Entry
{
    //variables
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _entryRate;

    //method
    public void Display()
    {
        Console.WriteLine($"[{_date}] | {_promptText} |\nResponse: {_entryText} |\nOverall day rating: {_entryRate}\n");
    }
}

