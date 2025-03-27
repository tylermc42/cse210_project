using System;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public void AddComment(string name, string text)
    {
        _comments.Add(new Comment(name, text));
    }
    public int CommentCount()
    {
        return _comments.Count;
    }
    public void VideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Lenght: {_length} seconds");
        Console.WriteLine($"Number of Comments: {CommentCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"{comment._name}: {comment._text}");
        }
    }
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
}