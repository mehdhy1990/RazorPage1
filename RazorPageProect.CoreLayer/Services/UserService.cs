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
    public OperationResult RegisterUser(UserRegisterDTO registerDto)
    {
        var UserName = _context.Users.Any(u => u.UserName == registerDto.UserName);
        if (UserName)
            OperationResult.Error("Username already exist");
        var passwordHash = registerDto.Password.EncodeToMd5();
        _context.Users.Add(new User()
        {
            UserName = registerDto.UserName,
            FullName = registerDto.FullName,
            IsDelete = false,
            Role = UserRole.User,
            CreateDate = DateTime.Now,
            Password = passwordHash,
           
        });
        _context.SaveChanges();
        return OperationResult.Success();
    }
}