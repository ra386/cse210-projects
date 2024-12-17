using System;

public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(string date, int minutes, int laps) : base (date, minutes)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60.0;
    }
    public override double GetPace()
    {
        return _minutes / GetDistance();
    }
}