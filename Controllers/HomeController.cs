using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using oneBox.Models;

namespace oneBox.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpGet]
    public IActionResult ChochoTray()
    {
        return View();
    }

    [HttpPost]
    // Get order and contact details from customer
    public IActionResult ChocoCart()
    {
        return View();
    }
}
