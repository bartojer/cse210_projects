class Comment
{
    private string _username;
    string _text;

    public Comment(string username, string text)
    {
        _username = username;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine();
        Console.WriteLine($"@{_username}");
        Console.WriteLine($"{_text}");
    }
}