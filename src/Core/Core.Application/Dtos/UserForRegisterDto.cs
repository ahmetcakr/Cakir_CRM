namespace Core.Application.Dtos;

public class UserForRegisterDto : IDto
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int AuthenticatorType { get; set; } = 0;

    public UserForRegisterDto()
    {
        Email = string.Empty;
        Password = string.Empty;
        FirstName = string.Empty;
        LastName = string.Empty;
        AuthenticatorType = 0;
    }

    public UserForRegisterDto(string email, string password, string firstName, string lastName, int authenticatorType)
    {
        Email = email;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
        AuthenticatorType = authenticatorType;
    }
}
