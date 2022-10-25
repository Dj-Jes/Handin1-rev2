namespace Domain.DTOs;

public class TodoBasicDto
{
    public int Id { get; }
    public string OwnerName { get; }
    public string Title { get; }
    public bool IsCompleted { get;  }

    public string Body { get; set; }

    
    
    public TodoBasicDto(int id, string ownerName, string title, bool isCompleted, string body)
    {
        Id = id;
        OwnerName = ownerName;
        Title = title;
        IsCompleted = isCompleted;
        Body = body;

    }
}