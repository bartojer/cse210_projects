class Simple : Goal
{
    string _finished = " ";

    public Simple(string name, string description, int pointValue, string finished) : base (name, description, pointValue)
    {
        _goalType = "simple";
        _finished = finished;
    }

    public override string Save()
    {
        return $"{base.Save()}, {_finished}";
    }
    public override int Record()
    {
        _finished = "X";
        return base.Record();
    }
    public override void Display()
    {
        Console.Write($"[{_finished}] ");
        base.Display();
        Console.WriteLine();
    }
}