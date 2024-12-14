using System;

public class CheckListGoal : Goal
{
    private int _Target;
    private int _AmountCompleted;
    private int _Bonus;

    private bool _isComplete;

    public CheckListGoal(string Name, string Description, int Points, int Target, int Bonus) : base(Name, Description, Points)
    {
        _Target = Target;
        _Bonus = Bonus;
        _AmountCompleted = 0;
        _isComplete = false;

    }

    public CheckListGoal(string Name, string Description, int Points, int Target, int Bonus, int Amount, bool isComplete) : base(Name, Description, Points)
    {
        _Target = Target;
        _Bonus = Bonus;
        _AmountCompleted = Amount;
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _AmountCompleted++;
            if (_AmountCompleted == _Target)
            {
                _isComplete = true;
                return _Points + _Bonus;
            }
            else
            {
                return _Points;
            }

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
        return $"CheckListGoal, {_ShortName}, {_Description}, {_Points}, {_Target}, {_Bonus}, {_AmountCompleted}, {_isComplete}";
    }

    public override string GetDetailString()
    {
        return base.GetDetailString() + $" - {_AmountCompleted}/{_Target}";
    }

}