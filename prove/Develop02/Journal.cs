class Journal
{
    public string _fileName;
    public void Load(string _loadFileName)
    {
        if (File.Exists(_loadFileName))
        {
            _fileName = _loadFileName;
            Console.WriteLine($"Journal file '{_fileName}' successfully loaded.");
        }
        else
        {
            Console.WriteLine($"We're sorry, we can't find the journal: {_loadFileName}");
        }
    }

    public static void NewJournal(string _newFileName)
    {
        _newFileName += ".txt";
        using StreamWriter outputFile = new(_newFileName);
        Console.WriteLine("Journal successfully created");
    }

    public void Display()
    {
        foreach (string line in File.ReadLines(_fileName))
        {
            Console.WriteLine(line);

        }
    }
}