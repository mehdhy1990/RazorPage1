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
        var IsUserNameExist = _context.Users.Any(u => u.UserName == registerDto.UserName);
        if (IsUserNameExist)
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

    public OperationResult LoginUser(LoginUserDTO loginDto)
    {
        var HashedPassword = loginDto.Password.EncodeToMd5();
        var IsUserNameExist = _context.Users.Any(u => u.UserName == loginDto.UserName
        && u.Password == HashedPassword);
        if(!IsUserNameExist)return OperationResult.NotFound();
        return OperationResult.Success();
    }
}