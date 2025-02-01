using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageProect.CoreLayer.Services;

namespace RazorPageProect.Web.Pages.Auth;

public class Register : PageModel
{
   private IUserService _userService;

    public Register(IUserService userService)
    {
        _userService = userService;
    }
    public void OnGet()
    {
        
    }
}