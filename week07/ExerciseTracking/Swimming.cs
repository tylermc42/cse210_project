using System;
public class Swimming : Activity
{
    private int _laps;
    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        //distance in miles = (laps * 50 meters / 1000) * 0.62
        return (_laps * 50.0 / 1000.0) * 0.62;
    }
    public override double GetSpeed()
    {
        //speed = distance / hours
        double hours = (double)_minutes / 60.0;
        return GetDistance() / hours;
    }
    public override double GetPace()
    {
        //pace = minutes/distance
        return _minutes / GetDistance();

    }
}