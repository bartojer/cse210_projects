using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompt = new();
        string newPrompt = prompt.GeneratePrompt();
        Console.WriteLine(newPrompt);

        Entry newEntry = new();
        newEntry._filename = "journal.txt";
        newEntry.Write();
        newEntry.Save(newPrompt);

        Journal newJournal = new();
        newJournal._filename = "journal.txt";
        newJournal.Display();




    }
}

//yall here?
// sure am!
//Yippee!!!




//DESIGN PHILOSOPHY:develop the simplest yet best built journal app.

/* MENU
    1. Write
    2. Display // Or call 'View Entries'
    3. Load
    4. Save
    5. Quit
*/

/* CLASSES:
    1. Jounal
        - Display
        - Load
    2. Entry
        - Write
        - Save
    3. PromptGenerator
        - (In tandem with 'Write')
*/

/* USER EXPERIENCE - AVENUES:
    A. Write only
        1. Open app
        2. Write (random prompt)
        3. Save
        4. Quit
    B. View only
        1. Open app
        2. Load
        3. Display
        4. Quit
    C. Load & write only
        1. Open app
        2. Load
        3. Write
        4. Save
        5. Quit
    D. Open & quit only
        1. Open app
        2. Quit app
    E.
        1. Open app
        2. Load (read)
        3. Quit
    F:
        1. 
        2. 
        3.
        4.
        5.
    G:
        1.
        2.
        3.
        4.
        5.

*/