using System;

public class EternalGoal : Goal
{
    private int _pointsPerEvent;
    private int _timesDone; 

    public EternalGoal(string name, string description, int pointsPerEvent) : base(name, description)
    {
        _pointsPerEvent = pointsPerEvent;
        _timesDone = 0;
    }

    public override int RecordEvent()
    {
        _timesDone++;
        return _pointsPerEvent;
    }

    public override string GetDetails()
    {
        return $"[ ] {_name}: {_description} (Done {_timesDone} times, {_pointsPerEvent} points each)";
    }

    public override string SaveData()
    {
        string safeName = _name.Replace(",", ";");
        string safeDescription = _description.Replace(",", ";");
        return $"EternalGoal,{safeName},{safeDescription},{_pointsPerEvent},{_timesDone}";
    }

    public void RestoreState(int timesDone)
    {
        _timesDone = timesDone;
    }
}