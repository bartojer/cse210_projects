abstract class Goal
{
    protected string _goalType = "";
    protected string _name;
    protected string _description;
    protected int _pointValue;
    protected string _goalFile = "";

    public Goal(string name, string description, int pointValue)
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
    }

    public virtual string Save()
    {
        return $"{_goalType}, {_name}, {_description}, {_pointValue}";
    }
    public virtual int Record()
    {
        return _pointValue;
    }
    public virtual void Display()
    {
        Console.Write($"{_name} ({_description})");
    }
}