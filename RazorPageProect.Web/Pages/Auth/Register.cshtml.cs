using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageProect.CoreLayer;
using RazorPageProect.CoreLayer.DTOs;
using RazorPageProect.CoreLayer.Services;

namespace RazorPageProect.Web.Pages.Auth;

[BindProperties]
public class Register : PageModel
{
    private IUserService _userService;

    #region Properties

    [Display(Name = "Username")]
    [Required(ErrorMessage = "Username is required")]
    public string UserName { get; set; }

    [Display(Name = "Email")]
    [Required(ErrorMessage = "Email is required")]
    public string FullName { get; set; }

    [Display(Name = "Password")]
    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; }

    #endregion

    public Register(IUserService userService)
    {
        _userService = userService;
    }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        var result = _userService.RegisterUser(new UserRegisterDTO()
        {
            FullName = FullName,
            UserName = UserName,
            Password = Password
        });
        if (result.Status == OperationResultStatus.Error)
        {
            ModelState.AddModelError("UserName", result.Message);
            return Page();
        }

        return RedirectToPage("Login");
    }
}