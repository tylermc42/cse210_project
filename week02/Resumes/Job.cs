using System;
// create class
public class Job 
{
    //create variables for data to be saved to
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;
    //function for print statement
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}