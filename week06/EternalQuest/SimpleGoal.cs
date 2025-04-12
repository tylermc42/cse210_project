using System;

public class SimpleGoal : Goal
{
    private int _points;

    public SimpleGoal(string name, string description, int points) : base(name, description)
    {
        _points = points;
    }

    public override int RecordEvent()
    {
        if (!_completed)
        {
            _completed = true;
            return _points;
        }
        return 0;
    }

    public override string GetDetails()
    {
        string status = _completed ? "[X]" : "[ ]";
        return $"{status} {_name}: {_description} ({_points} points)";
    }

    public override string SaveData()
    {
        string safeName = _name.Replace(",", ";");
        string safeDescription = _description.Replace(",", ";");
        return $"SimpleGoal,{safeName},{safeDescription},{_points},{_completed}";
    }

    public void RestoreState(bool completed)
    {
        _completed = completed;
    }
}