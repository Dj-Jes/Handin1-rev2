namespace Domain.DTOs;

public class TodoCreationDto
{
    public int OwnerId { get; }
    public string Title { get; }
    
    public string Context { get; }

    public TodoCreationDto(int ownerId, string title, string context)
    {
        OwnerId = ownerId;
        Title = title;
        Context = context;
    }
}