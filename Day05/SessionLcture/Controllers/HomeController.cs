using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SessionLcture.Models;
// ! Session Config Part 2
using Microsoft.AspNetCore.Http;
// !                                


namespace SessionLcture.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public static int usersCount = 0;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // HttpContext.Session.SetInt32("age", 36);
        // HttpContext.Session.SetString("username", "John");
        HttpContext.Session.SetInt32("usersCount", usersCount);
        return View();
    }

    public IActionResult Privacy()
    {
        string name  = HttpContext.Session.GetString("username");
        return View();
    }
    [HttpPost("users/create")]
    public IActionResult CreateUser(string username, int age, string favSport)
    {
        if (username is not null)
        {
            System.Console.WriteLine($"Username : {username}\nAge : {age}\nFavorite Sport : {favSport}");
            var count = HttpContext.Session.GetInt32("usersCount");
            int number = 0;
            if (count is not null)
            {
                usersCount += 1;
                number = (int)count;
            }
            HttpContext.Session.SetInt32("age", age);
            HttpContext.Session.SetString("username", value: username);
            HttpContext.Session.SetString("favSport", value: favSport);
            HttpContext.Session.SetInt32("usersCount", number += 1);
            return RedirectToAction("Privacy");
        }
        return RedirectToAction("Index");
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
