using System.ComponentModel;

class Customer
{
    private string _name;
    private Address _address;
    private bool _inUSA;

    public Customer(string name)
    {
        _name = name;
    }
    public void AddAddress(string street, string city, string state, string country)
    {
        _inUSA = country.ToLower() == "united states";
        _address = new Address(street, city, state, country);
    }
    public string GetAddress()
    {
        return _address.GetAddress();
    }
    public string GetName()
    {
        return _name;
    }
    public bool InUSA()
    {
        return _inUSA;
    }
}