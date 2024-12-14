using System;
using System.Drawing;
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string Name, string Description, int Points) : base(Name, Description, Points)
    {
        _ShortName = Name;
        _Description = Description;
        _Points = Points;

    }

    public SimpleGoal(String Name, string Description, int Points, bool isComplete) :base (Name, Description, Points)
    {
         _ShortName = Name;
        _Description = Description;
        _Points = Points;
        _isComplete = isComplete;

    }

    public override int RecordEvent()
    {
        if(!_isComplete)
        {
            _isComplete = true;
            return _Points;
        }
        else
        {
            return 0;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal, {_ShortName}, {_Description}, {_Points}, {_isComplete}";
    }
}