class Activity{
    protected string _name;
    protected int _duration;
    protected string _description;
    protected string _verb;

    protected string _ending;

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} activity\n");
        Console.WriteLine($"How long would you like to {_verb}?");
        Console.Write("> ");
        _duration = Convert.ToInt32(Console.ReadLine());
        DisplayMessage();
    }

    public void DisplayMessage()
    {
        Console.WriteLine($"{_description}\n");
    }

    public void End()
    {
        Console.WriteLine(_ending);
    }

    public static void CountDown(int time)
{
    for (int i = time; i > 0; i--)
    {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b");
    }
}
}