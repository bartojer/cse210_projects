class Numbered : Goal
{
    private int _totalChecks;
    private int _completedChecks;
    private int _bonus;
    private string _finished = " ";

    public Numbered(string name, string description, int pointValue, string finished, int completedChecks, int totalChecks, int bonus) : base (name, description, pointValue)
    {
        _goalType = "numbered";
        _completedChecks = completedChecks;
        _totalChecks = totalChecks;
        _bonus = bonus;
        _finished = finished;
    }

    public override int Record()
    {
        _completedChecks ++;
        if (_completedChecks == _totalChecks)
        {
            _pointValue += _bonus;
            _finished = "X";
        }
        return base.Record();
    }
    public override string Save()
    {
        return $"{base.Save()}, {_finished}, {_completedChecks}, {_totalChecks}, {_bonus}";
    }
    public override void Display()
    {
        Console.Write($"[{_finished}] ");
        base.Display();
        Console.WriteLine($" -- Currently completed: {_completedChecks}/{_totalChecks}");
    }
}