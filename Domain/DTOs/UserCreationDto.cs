namespace Domain.DTOs;

public class UserCreationDto
{
    public string UserName { get;}
    public int Id { get;}
    public string MailAdress { get;}
    public string PassWord { get; }
    

    public UserCreationDto(string userName, String mailAdress, String passWord )
    {
        UserName = userName;
        MailAdress = mailAdress;
        PassWord = passWord;

    }
}