namespace Domain.DTOs;

public class TodoCreationDto
{
    public int OwnerId { get; }
    public string Title { get; }

    public string Body{ get; set; }
    
  

    public TodoCreationDto(int ownerId, string title, string body)
    {
        OwnerId = ownerId;
        Title = title;
        Body = body;

    }
}