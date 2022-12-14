using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _278Project.Models;
using _278Project.Repos;

namespace _278Project.Controllers;

public class HomeController : Controller
{

    private readonly IUsersRepo _usersRepo;

    public HomeController(IUsersRepo usersRepo)
    {
        _usersRepo = usersRepo;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult AboutUs()
    {
        return View();
    }
    // public IActionResult BabyCare()
    // {
    //     var products = _usersRepo.getProducts();
    //     return View(products);
    // }
    // public IActionResult Beauty()
    // {
    //     var products = _usersRepo.getProducts();
    //     return View(products);
    // }

    // public IActionResult Food()
    // {
    //     var products = _usersRepo.getProducts();
    //     return View(products);
    // }
    // public IActionResult FruitesAndVeggies()
    // {
    //     var products = _usersRepo.getProducts();
    //     return View(products);
    // }
    // public IActionResult Gardening()
    // {
    //     var products = _usersRepo.getProducts();
    //     return View(products);
    // }
    // public IActionResult Office()
    // {
    //     var products = _usersRepo.getProducts();
    //     return View(products);
    // }
    public IActionResult NewArrivals()
    {
        return View();
    }
    public IActionResult BestSellers()
    {
        return View();
    }

    public IActionResult BestDeals()
    {
        return View();
    }
    public IActionResult LogReg()
    {
        return View();
    }
    public IActionResult ShoppingCart()
    {
        return View();
    }

    public IActionResult Payment()
    {
        return View();
    }

    public IActionResult PaymentConfirmation()
    {
        return View();
    }

    public IActionResult Profile()
    {
        return View();
    }

    public IActionResult WishList()
    {
        return View();
    }

    public IActionResult DetailsForCheckout()
    {
        return View();
    }

    public IActionResult Categories()
    {
        return Redirect(Url.Action("Index", "Home") + "#category");
    }

    public IActionResult Promotions()
    {
        return Redirect(Url.Action("Index", "Home") + "#BestPromotions");
    }

    public IActionResult App()
    {
        return Redirect(Url.Action("Index", "Home") + "#download-app");
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
