using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction(15);
        Fraction frac3 = new Fraction(5, 16);

        //fraction 1
        Console.WriteLine("fraction 1");
        frac1.SetTop(15);
        frac1.SetBottom(9);
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());

        //fraction 2
        Console.WriteLine("fraction 2 - 1");
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDecimalValue());

        frac2.SetTop(5);
        frac2.SetBottom(15);
        Console.WriteLine("fraction 2 - 2");
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDecimalValue());

        //fraction 3
        Console.WriteLine("fraction 3 - 1");
        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetDecimalValue());
        
        frac3.SetTop(95);
        frac3.SetBottom(4);
        Console.WriteLine("fraction 3 - 2");
        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetDecimalValue());
    }
}