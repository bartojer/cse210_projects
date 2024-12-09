class Reception:Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, string address, string email):  base(title, description, date, time, address)
    {
        _email = email;
        _eventType = "Reception";
    }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}, Email: {_email}";
    }
}