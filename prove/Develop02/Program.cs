using System;
using System.Net.Quic;

class Program

{
    static void Main(string[] args)
    {

    // 1. Write
    // 2. Display // Or call 'View Entries'
    // 3. Load
    // 4. Save
    // 5. Quit

        PromptGenerator prompt = new();
        Journal journal = new();
        Entry entry = new();
        int i = 1;
        
        while (true)
        {
            if (i == 1)
            {
                entry._fileName = "journal1.txt";
                journal._fileName = "journal1.txt";
                i = 2;
            }
            Console.WriteLine();
            DisplayMenu();
            string menuInput = Console.ReadLine();

            if ("1" == menuInput)   // write
            {
                string newPrompt = prompt.GeneratePrompt();
                Console.WriteLine(newPrompt);
                entry.Write();
                entry.Save(newPrompt); 
            }

            else if ("2" == menuInput)  // display
            {
                journal.Display();
            }

            else if ("3" == menuInput)  //load
            {
                Console.WriteLine("Type '1' to load an existing journal, or '2' to create a new journal.");
                Console.WriteLine("Press anything else to go back to menu.");
                Console.Write("> ");
                string loadInput = Console.ReadLine();
                Console.WriteLine();

                if ("1" == loadInput)   // existing journal
                {
                    ShowTextFiles();
                    Console.WriteLine();

                    Console.WriteLine("Enter the journal name:");
                    Console.Write("> ");
                    string loadFileName = Console.ReadLine() + ".txt";
                    entry._fileName = loadFileName;
                    journal.Load(loadFileName);
                }
                
                else if ("2" == loadInput)  // new journal
                {
                    Console.WriteLine("Enter new journal name. If using multiple words, connect_them_with_underscores (no spaces).");
                    Console.Write("> ");
                    string newFileName = Console.ReadLine();
                    Journal.NewJournal(newFileName);
                    journal.Load(newFileName);
                }
                else{
                    continue;
                }
            }

            else if (("4" == menuInput) || ("q" == menuInput))  // quit
            {
                break;
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Type a number between 1 and 4, then press enter.");
                continue;
            }
        }
    }

    static void DisplayMenu()
    {
        List<string> menu = ["1. Write", "2. Display", "3. Load", "4. Quit"];

        Console.WriteLine("Main Menu: please choose from the following options");
        foreach (string item in menu)
        {
            Console.WriteLine(item);
        }
        Console.Write("> ");
    }

    static void ShowTextFiles()
    {
        string[] txtFiles = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt");

        if (0 == txtFiles.Length)
        {
            Console.WriteLine("No journal files found.");
        }
        else
        {
            Console.WriteLine("Available journal files:");
            foreach (string file in txtFiles)
            {
                Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            }
        }
    }
}