using RazorPageProect.CoreLayer.DTOs;

namespace RazorPageProect.CoreLayer.Services;

public interface IUserService
{
    void RegisterUser(UserRegisterDTO registerDto);
}