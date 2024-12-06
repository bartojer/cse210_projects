using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = [];

        Customer jenny = new("Jenny");
        jenny.AddAddress("123 Main St", "Seattle", "WA", "United States");
        Order orderJenny = new(jenny);
        orderJenny.AddProduct(new("cow milk", 3));
        orderJenny.AddProduct(new("goat cheese", 1));
        orderJenny.AddProduct(new("mozzarella", 4));
        orders.Add(orderJenny);

        Customer mario = new("Mario");
        mario.AddAddress("456 Via Roma", "Rome", "RM", "Italy");
        Order orderMario = new(mario);
        orderMario.AddProduct(new("mozzarella", 16));
        orderMario.AddProduct(new("goat milk", 4));
        orderMario.AddProduct(new("goat cheese", 2));
        orderMario.AddProduct(new("cow milk", 12));
        orders.Add(orderMario);

        Customer sarah = new("Sarah");
        sarah.AddAddress("789 Maple Ave", "Vancouver", "BC", "Canada");
        Order orderSarah = new(sarah);
        orderSarah.AddProduct(new("goat milk", 3));
        orderSarah.AddProduct(new("cow milk", 3));
        orders.Add(orderSarah);

        Console.WriteLine("Press enter to see orders");
        Console.ReadLine();

        PrintOrderDetails();

        void PrintOrderDetails()
        {
            foreach (Order order in orders)
            {
                Console.WriteLine("----------------");
                Console.WriteLine("SHIPPING LABEL:");
                order.DisplayShipingLabel();
                Console.WriteLine("\nPACKING LABEL:");
                order.DisplayPackingLabel();
                Console.WriteLine($"\nTOTAL COST: ${order.TotalCost():F2}");
                Console.WriteLine("------------------------");
            }
        }
    }
}