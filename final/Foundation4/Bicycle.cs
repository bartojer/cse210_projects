class Bicycle : Exercise
{
    public Bicycle(string date, int minutes, int speed) : base(date, minutes)
    {
        _speed = speed;
        _exerciseType = "Bicycling";
    }

    public override double GetDistance()
    {
        _distance = _speed * _minutes / 60;
        return _distance;
    }
    public override string GetSummary()
    {
        return base.GetSummary() + $", Speed: {_speed:F2} kph";
    }
}