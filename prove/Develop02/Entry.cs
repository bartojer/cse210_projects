using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Threading.Tasks.Dataflow;

class Entry
{
    //make entry
    public string _fileName;   // where it saves
    DateTime _date = DateTime.Now;      //dates entry
    string _newEntry;
    string _titleEntry;
    public void Write()
    {
        //accept input
        _newEntry = Console.ReadLine(); 
        Console.WriteLine("What would you like to title this entry?");
        _titleEntry = Console.ReadLine();
    }
    public void Save(string prompt)
    {
        
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

        string _title = textInfo.ToTitleCase(_titleEntry);
        //save _today, _title, _newEntry to _filename
        using (StreamWriter outputFile = new(_fileName, true))
        {
            outputFile.WriteLine(_date);
            outputFile.WriteLine(_title);
            outputFile.WriteLine("--------");
            outputFile.WriteLine(prompt);
            outputFile.WriteLine(_newEntry);
            outputFile.WriteLine();
            outputFile.WriteLine("-=-=-=-");
            outputFile.WriteLine();
        }
    }
}