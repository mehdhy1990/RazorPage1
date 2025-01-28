namespace RazorPageProect.DataLayer.Entities;

public class User
{
    public string UserName { get; set; }
    public string  FullName { get; set; }
    public string Password { get; set; }
    public UserRole Role { get; set; }
}

public enum UserRole
{
    Admin,
    User,
    Write
}