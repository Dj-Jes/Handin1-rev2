namespace Domain.Models;

public class Todo
{
    public int Id { get; set; }
    public User Owner { get; }
    public string Title { get; }

    public string Body { get; }
   

    public bool IsCompleted { get; set; }

    public Todo(User owner, string title, string body)
    {
        Owner = owner;
        Title = title;
        Body = body;

    }
}