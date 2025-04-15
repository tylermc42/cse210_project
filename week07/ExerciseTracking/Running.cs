using System;
public class Running : Activity
{
    private double _distance; //in miles
    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        //speed = distance/hours(convert to minutes)
        double hours = (double)_minutes / 60.0;
        return _distance/hours;
    }
    public override double GetPace()
    {
        //pace = minutes/distance
        return _minutes/_distance;
    }
}