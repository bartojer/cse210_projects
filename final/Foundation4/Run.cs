class Run:Exercise
{
    public Run(string date, int minutes, int distance) : base(date, minutes)
    {
        _distance = distance;
        _exerciseType = "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }
}