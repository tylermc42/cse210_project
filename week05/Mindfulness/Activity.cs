using System;

class Activity
{
    private string _name;
    private string _description;
    public int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void Start()
    {
        Console.WriteLine($"\n--{_name}--");
        Console.WriteLine(_description);
        Console.WriteLine("\nGet ready...");
        ShowDots(3);
    }
    public void End()
    {
        Console.WriteLine("\nGreat Job!");
        ShowDots(3);
        Console.WriteLine($"You finished {_name}");
        ShowDots(3);
    }
    public void ShowDots(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Wait(1);
        }
        Console.WriteLine();
    }
    public int GetSecondsFromUser()
    {
        while (true)
        {
            Console.Write("How many seconds do you want to do this? ");
            string input = Console.ReadLine();
            int number;
            if (int.TryParse(input, out number) && number > 0)
            {
                return number;
            }
            Console.WriteLine("Please enter a number greater than 0");
        }
    }
    public void Wait(int seconds)
    {
        Thread.Sleep(seconds * 1000);
    }
}