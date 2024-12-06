class Order
{
    List<Product> _products = [];
    Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalCost()
    {
        double totalCost = 5;
        foreach (Product product in _products)
        {
            totalCost += product.GetPrice() * product.GetQuantity();
        }
        if (!_customer.InUSA())
        {
            totalCost += 30;
        }
        return totalCost;
    }
    public void DisplayPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine(product.Packing());
        }
    }
    public void DisplayShipingLabel()
    {
        Console.WriteLine($"{_customer.GetName()}, {_customer.GetAddress()}");
    }
}