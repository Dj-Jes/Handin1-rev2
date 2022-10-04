namespace Domain.DTOs;

public class UserCreationDto
{
    public string UserName { get;}
    public int Id { get;}
    public string MailAdress { get;}
    public string PassWord { get; }
    

    public UserCreationDto(string userName, int id, String mailAdress, String passWord )
    {
        UserName = userName;
        Id = id;
        MailAdress = mailAdress;
        PassWord = passWord;

    }
}