using System;

public  abstract class Goal
{
    protected string _ShortName;
    protected string _Description;
    protected int _Points;

    public Goal (string Name, string Description, int Points)
    {
        _ShortName = Name;
        _Description = Description;
        _Points = Points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailString()
    {
        char mark = IsComplete()?'x':' ';

        return $"[{mark}] {_ShortName} ({_Description})";

    }

    public virtual  string GetDetailString2()
    {
        return $"{_ShortName} ({_Description})";
    }

    public abstract string GetStringRepresentation();



}