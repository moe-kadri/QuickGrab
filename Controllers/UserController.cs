using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _278Project.Models;
using _278Project.Repos;
using _278Project.Data;

namespace _278Project.Controllers;

public class UserController : Controller
{
    private readonly IUsersRepo _UsersRepo;

    public UserController(IUsersRepo usersRepo)
    {
        _UsersRepo= usersRepo;
    }

    public IActionResult Index()
    {
        return View();
    }
   
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
