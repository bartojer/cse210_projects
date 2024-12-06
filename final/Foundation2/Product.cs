class Product
{
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    public double GetPrice()
    {
        return _price;
    }
    public int GetQuantity()
    {
        return _quantity;
    }

    public Product(string preset, int quantity)
    {
        switch (preset.ToLower())
        {
            case "goat cheese":
                _name = "Goat Cheese";
                _id = 1;
                _price = 5.99;
                _quantity = quantity;
                break;
                
            case "goat milk":
                _name = "Goat Milk";
                _id = 2;
                _price = 4.99;
                _quantity = quantity;
                break;
                
            case "mozzarella":
                _name = "Mozzarella";
                _id = 3;
                _price = 6.99;
                _quantity = quantity;
                break;
                
            case "cow milk":
                _name = "Cow Milk";
                _id = 4;
                _price = 4.59;
                _quantity = quantity;
                break;
        }
    }

    public string Packing()
    {
        return $"{_name}, id: {_id}, quantity: {_quantity}";
    }
}