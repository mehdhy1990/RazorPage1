using RazorPageProect.CoreLayer.DTOs;
using RazorPageProect.DataLayer.Context;
using RazorPageProect.DataLayer.Entities;

namespace RazorPageProect.CoreLayer.Services;

public class UserService :IUserService
{
    private readonly BlogContext _context;

    public UserService(BlogContext context)
    {
        _context = context;
    }
    public void RegisterUser(UserRegisterDTO registerDto)
    {
        var UserName = _context.Users.Any(u => u.UserName == registerDto.UserName);
        if (UserName)
            OperationResult.Error("Username already exist");
        _context.Users.Add(new User()
        {
            UserName = registerDto.UserName,
            FullName = registerDto.FullName,
            IsDelete = false,
            Role = UserRole.User,
            CreateDate = DateTime.Now,
           
        });
    }
}