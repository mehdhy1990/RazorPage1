using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageProect.CoreLayer;
using RazorPageProect.CoreLayer.DTOs;
using RazorPageProect.CoreLayer.Services;

namespace RazorPageProect.Web.Pages.Auth;
[RequireAntiforgeryToken]
[BindProperties]
public class Login : PageModel
{
    private IUserService _userService;

    public Login(IUserService userService)
    {
        _userService = userService;
    }
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
    public void OnGet()
    {
        
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid) return Page();
        var resutl = _userService.LoginUser(new LoginUserDTO()
        {
            UserName = UserName,
            Password = Password
        });
        if (resutl.Status == OperationResultStatus.NotFound)
        {
            ModelState.AddModelError("UserName", "Invalid username or password.");
        }
        return RedirectToPage("../Index");
    }
}