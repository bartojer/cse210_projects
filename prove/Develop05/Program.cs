using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new();
        Console.WriteLine("\nWelcome to your goal setting and tracking application!\n");
        string choice = "";
        while (choice != "6" && choice != "q")
        {
            Console.WriteLine($"Total Points: {menu._totalPoints}");
            Menu.DisplayMenu();
            choice = Console.ReadLine();
            Console.Clear();

            switch(choice)
            {
                case "1":
                    menu.CreateGoal();
                    break;

                case "2":
                    Console.WriteLine("Your current goals:\n");
                    menu.ListGoals();
                    break;

                case "3":
                    // Console.WriteLine("Enter file name:");
                    // Console.Write("> ");
                    // string saveFileName = Console.ReadLine();
                    menu.SaveGoals();
                    break;

                case "4":
                    // Console.WriteLine("Enter file name:");
                    // Console.Write("> ");
                    // string loadFileName = Console.ReadLine();
                    menu.LoadFromFile();
                    break;

                case "5":
                    menu.Record();
                    break;

                case "6" or "q":
                    break;
            }
        }
    }
}