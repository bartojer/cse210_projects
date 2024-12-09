using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Event> _events = [];


        _events.Add(new Lecture(
            "SpongeBob SquarePants: The Science of Jellyfishing",
            "Explore the fascinating world of jellyfish with Dr. Sandy Cheeks.",
            "2024-11-15",
            "10:00",
            "Bikini Bottom Science Center",
            "Dr. Sandy Cheeks",
            90
        ));

        _events.Add(new Reception(
            "Fairly Odd Parents: Magic and Mayhem",
            "Cosmo and Wanda",
            "2024-12-20",
            "19:00",
            "Dimmsdale Community Hall",
            "rsvp@fairlyoddparents.com"
        ));

        _events.Add(new Outdoor(
            "Jimmy Neutron",
            "Inventions in the Park",
            "2024-10-10",
            "16:00",
            "Retroville Central Park",
            "Sunny"
        ));

        Console.WriteLine("Press enter to see event details");
        Console.ReadLine();

        foreach (Event evt in _events)
        {
            DisplayDetails(evt);
        }


        void DisplayDetails(Event evt)
        {
            Console.WriteLine("\n---------------------");
            Console.WriteLine("\nSTANDARD DETAILS:");
            Console.WriteLine(evt.StandardDetails());
            Console.WriteLine("\nFULL DETAILS:");
            Console.WriteLine(evt.FullDetails());
            Console.WriteLine("\nSHORT DESCRIPTION");
            Console.WriteLine(evt.ShortDescription());
            Console.WriteLine("--------------------------\n");
        }
    }
}