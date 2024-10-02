using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Costume nurse = new();
        Console.WriteLine("Nurse garb:");
        nurse._headWear = "Face Mask";
        nurse._handWear = "Nitrile gloves";
        nurse._footWear = "Orthopedic sneakers";
        nurse._upperGarment = "Scrubs";
        nurse._lowerGarment = "Scrubs";
        nurse._accessory = "Stethoscope";

        Costume detective = new();
        Console.WriteLine("Detective garb:");
        detective._headWear = "Fedora";
        detective._handWear = "Leather";
        detective._footWear = "Loafers";
        detective._upperGarment = "Trenchcoat";
        detective._lowerGarment = "Slacks";
        detective._accessory = "Magnifying glass";

        Costume cowboy = new();
        Console.WriteLine("Detective garb:");
        cowboy._headWear = "Cowboy hat";
        cowboy._handWear = "Work";
        cowboy._footWear = "Boots";
        cowboy._upperGarment = "Flanel";
        cowboy._lowerGarment = "Jeans";
        cowboy._accessory = "Lasso";

        Console.WriteLine("Nurse garb:");
        nurse.ShowWardrobe();
        Console.WriteLine();
        

        Console.WriteLine("Detective garb:");
        detective.ShowWardrobe();
        Console.WriteLine();
        
        Console.WriteLine("Cowboy garb:");
        cowboy.ShowWardrobe();
    }
}