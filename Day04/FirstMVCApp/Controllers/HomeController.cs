using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstMVCApp.Models;

namespace FirstMVCApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    public static List<Song> AllSongs { get; set; } = new();

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
        return View(AllSongs);
    }

    public IActionResult OneSong()
    {
        return View();
    }

    [HttpPost("create/v0/songs")]
    public IActionResult CreateSong(string title, string singer, int releaseYear, bool isExplicit)
    {
        ViewBag.Title = title;
        ViewBag.Singer = singer;
        ViewBag.ReleaseYear = releaseYear;
        ViewBag.IsExplicit = isExplicit;
        return RedirectToAction("OneSong");
    }
    [HttpPost]
    public IActionResult CreateSongV1(Song newSong)
    {
        if(ModelState.IsValid)
        {
            System.Console.WriteLine($"Title :{newSong.Title}\nSinger :{newSong.Singer}\nReleaseYear :{newSong.ReleaseYear}\nIsExplicit :{newSong.IsExplicit}\n");
            AllSongs.Add(newSong);
            return RedirectToAction("Privacy");
        }
        return View("Index");
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
