class Lecture:Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, string address, string speaker, int capacity):  base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}, Speaker: {_speaker}, Capacity: {_capacity}";
    }
}