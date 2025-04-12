using System;

public class Goal
{
    protected string _name; // Protected so derived classes can access
    protected string _description;
    protected bool _completed;

    public Goal(string name, string description)
    {
        _name = name;
        _description = description;
        _completed = false;
    }

    // Virtual methods for derived classes to override
    public virtual int RecordEvent()
    {
        return 0;
    }

    public virtual string GetDetails()
    {
        return "";
    }

    public virtual string SaveData()
    {
        return "";
    }
}