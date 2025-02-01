using RazorPageProect.CoreLayer.DTOs;

namespace RazorPageProect.CoreLayer.Services;

public interface IUserService
{
    OperationResult RegisterUser(UserRegisterDTO registerDto);
}