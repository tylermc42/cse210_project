using System;
public class Cycling : Activity
{
    private double _speed; //in mph
    public Cycling(DateTime date, int minutes, double speed) : base (date, minutes)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        //Distance = speed * hours
        double hours = (double)_minutes / 60.0;
        return _speed * hours;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60.0 / _speed;
    }
}