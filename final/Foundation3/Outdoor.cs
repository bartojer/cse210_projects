class Outdoor:Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, string address, string weather):  base(title, description, date, time, address)
    {
        _weather = weather;
        _eventType = "Outdoor";
    }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}, Weather: {_weather}";
    }
}