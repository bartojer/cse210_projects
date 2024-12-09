abstract class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _eventType;

    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public virtual string StandardDetails()
    {
        return $"{_title}, {_description}, {_date}, {_time}, {_address}";
    }
    public virtual string FullDetails()
    {
        return $"{_title}, {_description}, {_date}, {_time}, {_address}";
    }
    public virtual string ShortDescription()
    {
        return $"{_eventType}, {_title}, {_date}";
    }
}