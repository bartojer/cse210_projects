using System;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }
    
    public static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Welcome to Meditation for Dummies: Gateway to Monkhood");
        string input = "";
        while (input != "q")
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Reflect");
            Console.WriteLine("2. List");
            Console.WriteLine("3. Breathe");
            Console.WriteLine("q. Quit");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Reflect reflection = new Reflect();
                    reflection.Start();
                    reflection.RunReflection();
                    break;
                case "2":
                    List list = new List();
                    list.Start();
                    list.RunListing();
                    break;
                case "3":
                    Breath breath = new Breath();
                    breath.Start();
                    breath.RunBreathing();
                    break;
                case "q":
                    Console.WriteLine("Quitting...");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}