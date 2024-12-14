using System;

public class EternalGoal : Goal
{
    public EternalGoal(string Name, string Description, int Points) : base(Name, Description, Points)
    {
         _ShortName = Name;
        _Description = Description;
        _Points = Points;

    }

    public override int RecordEvent()
    {
        return _Points;
    }

    public override bool IsComplete()
    {
        return false;

    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal, {_ShortName}, {_Description}, {_Points}";
    }
}