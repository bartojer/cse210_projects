class Eternal : Goal
{
    int _iterations = 0;

    public Eternal(string name, string description, int pointValue, int iterations) : base (name, description, pointValue)
    {
        _goalType = "eternal";
        _iterations = iterations;
    }

    public override string Save()
    {
        return $"{base.Save()}, {_iterations}";
    }
    public override int Record()
    {
        _iterations ++;
        return base.Record();
    }
    public override void Display()
    {
        Console.Write("[E] ");
        base.Display();
        Console.WriteLine($" [{_iterations} times]");
    }
}