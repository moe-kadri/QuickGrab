using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _278Project.Models;
using System.Diagnostics;
using _278Project.Repos;
using Microsoft.AspNetCore.Identity;

namespace _278Project.Controllers;

public class AccountController : Controller
{
    private UserManager<User> userManager;
    private SignInManager<User> signInManager;


    public AccountController(UserManager<User> userMngr, SignInManager<User> signInMngr)
    {
        userManager = userMngr;
        signInManager = signInMngr;
    }
    [HttpGet]
    public IActionResult Register()
    {
        var display = new RegisterViewModel { };
        return View(display);
    }
    [HttpPost]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            var user = new User { UserName = model.Username };
            var result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
        }
        return View(model);
    }

    [HttpGet]
    public IActionResult LogIn(string returnURL = "")
    {
        var model = new LoginViewModel { ReturnUrl = returnURL };
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> LogIn(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var result = await signInManager.PasswordSignInAsync(
            model.Email, model.Password,
            isPersistent: model.RememberMe,
            lockoutOnFailure: false);
            if (result.Succeeded)
            {
                if (!string.IsNullOrEmpty(model.ReturnUrl) &&
                Url.IsLocalUrl(model.ReturnUrl))
                {
                    return Redirect(model.ReturnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
        }
        ModelState.AddModelError("", "Invalid username/password.");
        return View(model);
    }
    [HttpPost]
    public async Task<IActionResult> LogOut()
    {
        await signInManager.SignOutAsync();
        return RedirectToAction("Index", "Home");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
