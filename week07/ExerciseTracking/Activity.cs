using System;
// Base class for all activities
public abstract class Activity
{
    //private fields (encapsulation)
    protected DateTime _date;
    protected int _minutes;
    
    //constructor to set date and minutes
    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    //method to get the summary
    public virtual string GetSummary()
    {
        return $"{_date:dd MM yyyy} {this.GetType().Name} ({_minutes} min)- \nDistance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph \nPace: {GetPace(): F1} min per mile";
    }

    //abstract methods that children classes must implement
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
}