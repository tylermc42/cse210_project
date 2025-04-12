using System;

public class ChecklistGoal : Goal
{
    private int _pointsPerEvent;
    private int _targetCount;
    private int _bonusPoints;
    private int _currentCount; 

    public ChecklistGoal(string name, string description, int pointsPerEvent, int targetCount, int bonusPoints) : base(name, description)
    {
        _pointsPerEvent = pointsPerEvent;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            int points = _pointsPerEvent;
            if (_currentCount == _targetCount)
            {
                _completed = true;
                points += _bonusPoints;
            }
            return points;
        }
        return 0;
    }

    public override string GetDetails()
    {
        string status = _completed ? "[X]" : "[ ]";
        return $"{status} {_name}: {_description} (Done {_currentCount}/{_targetCount} times, {_pointsPerEvent} points each, {_bonusPoints} bonus)";
    }

    public override string SaveData()
    {
        string safeName = _name.Replace(",", ";");
        string safeDescription = _description.Replace(",", ";");
        return $"ChecklistGoal,{safeName},{safeDescription},{_pointsPerEvent},{_targetCount},{_bonusPoints},{_currentCount},{_completed}";
    }

    public void RestoreState(int currentCount, bool completed)
    {
        _currentCount = currentCount;
        _completed = completed;
    }
}