class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    // private bool _inUSA;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // private void SetInUSA()
    // {
    //     _inUSA = (_country.ToLower() == "united states");
    // }
    // public bool InUSA()
    // {
    //     SetInUSA();
    //     return _inUSA;
    // }

    public string GetAddress()
    {
        return $"{_street}, {_city}\nl{_state}, {_country}";
    }

}