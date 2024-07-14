using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using learnMVC.Models;

namespace learnMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public string Show()
    {
        return "this is second action method";
    }
    public ActionResult AboutUs()
    {
        return View();
    }
    public int Studentid(int id)
    {
        return id;
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
