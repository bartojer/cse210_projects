class Swim: Exercise
{
private readonly int _laps;

public Swim(string date, int minutes, int laps) : base(date, minutes)
{
    _laps = laps;
    _exerciseType = "Swimming";
}

    public override double GetDistance()
    {
        _distance = _laps * 50 / 1000.0;
        return _distance;
    }
    public override string GetSummary()
    {
        return base.GetSummary() + $", Laps: {_laps}";
    }
}