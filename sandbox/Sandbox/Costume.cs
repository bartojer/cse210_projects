class Costume
{
    //attributes (member variables)
    public string _headWear;
    public string _handWear;
    public string _footWear;
    public string _upperGarment;
    public string _lowerGarment;
    public string _accessory;


    //behaviors (member functions or *methods*)
    public void ShowWardrobe()
    {
        string result = "";
        result += "Head wear: " + _headWear;
        result += "\nHand wear: " + _handWear;
        result += "\nFoot wear: " + _footWear;
        result += "\nUpper wear: " + _upperGarment;
        result += "\nLower wear: " + _lowerGarment;
        result += "\nAccessory: " + _accessory;

        Console.WriteLine(result);

        
    }



}