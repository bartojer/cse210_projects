class Journal
{
    public string _filename;

    public string Load()
    {
        return "";
    }

    public void Display()
    {
        foreach (string line in File.ReadLines(_filename))
        {
            Console.WriteLine(line);

        }
    }
}