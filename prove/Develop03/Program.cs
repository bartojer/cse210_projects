using System;
using System.Diagnostics;
using System.Net.Quic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Verse verse = new Verse();
        Reference reference = new Reference("Moses", 1, 39);
        verse.MakeVerse("For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.");

        Console.WriteLine(reference.ReturnReference());
        Console.WriteLine(verse.ReturnVerse());

        while (!verse.AllWordsHidden())
        {
            if (!UserQuit())
            {
                verse.HideWord(3);
                Console.Clear();
                Console.WriteLine(reference.ReturnReference());
                Console.WriteLine(verse.ReturnVerse());
            }
            else
            {
                System.Environment.Exit(0);
            }
        }
        Console.WriteLine("All words are hidden!");

        Console.WriteLine("Press enter to see the verse again.");
        
        if (!UserQuit())
        {
            Console.Clear();
            Console.WriteLine(reference.ReturnReference());
            Console.WriteLine(verse.RememberVerse());
        }
        else
        {
            System.Environment.Exit(0);
        }
        
        bool UserQuit()
        {
            Console.WriteLine("\nPress enter to continue or type quit to exit.");
            string usrInput = Console.ReadLine();
            return "quit" == usrInput.ToLower();
        }
    }
}