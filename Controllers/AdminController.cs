using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _278Project.Models;
using _278Project.Repos;
using Microsoft.AspNetCore.Authorization;

namespace _278Project.Controllers;
[Authorize]
public class AdminController : Controller
{
    private readonly IAdminsRepo _AdminsRepo;

    public AdminController(IAdminsRepo adminsRepo)
    {
        _AdminsRepo = adminsRepo;
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

