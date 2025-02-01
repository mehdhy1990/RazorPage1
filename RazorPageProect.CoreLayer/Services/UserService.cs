using RazorPageProect.CoreLayer.DTOs;
using RazorPageProect.DataLayer.Context;

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
        var FullNameExist = _context.Users.Any(u => u.FullName == registerDto.FullName);
        if (FullNameExist)
            throw new Exception();
    }
}