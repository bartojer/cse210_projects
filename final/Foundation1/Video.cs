using System.ComponentModel.DataAnnotations;
using System.Transactions;

class Video
{
    private string _title;
    private string _author;
    private int _seconds;
    private List<Comment> _comments = [];

    public Video(string title, string author, int seconds)
    {
        _title = title;
        _author = author;
        _seconds = seconds;
    }

    public void AddComment(string username, string text)
    {
        _comments.Add(new Comment(username, text));
    }

    // public string CommentCount()
    // {
    //     return $"{_title} has {_comments.Count} comments";
    // }
    public void DisplayInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"{_seconds} seconds");
        Console.WriteLine($"({_comments.Count} comments)");
        Console.WriteLine();
        Console.WriteLine("Comments:");
        DisplayComments();
        Console.WriteLine();
    }
    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}