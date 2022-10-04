namespace Domain.Models;

public class Todo
{
    public int Id { get; set; }
    public User Owner { get; }
    public string Title { get; }
    public string Context { get; }

    public bool IsCompleted { get; set; }

    public Todo(User owner, string title, string context)
    {
        Owner = owner;
        Title = title;
        Context = context;
    }
}