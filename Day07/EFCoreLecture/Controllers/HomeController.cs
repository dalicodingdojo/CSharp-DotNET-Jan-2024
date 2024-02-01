using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EFCoreLecture.Models;

namespace EFCoreLecture.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    // ---------------------------------------
    private readonly AppDbContext _db;
    // ---------------------------------------


    public HomeController(ILogger<HomeController> logger, AppDbContext db)    // ---------------------------------------

    {
        _logger = logger;
        // ---------------------------------------
        _db = db;
        // ---------------------------------------
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        List<Album> allAlbums = _db.Albums.ToList();
        return View(allAlbums);
    }
    public IActionResult Edit(int albumId)
    {
        Album album = _db.Albums.FirstOrDefault(a => a.AlbumId == albumId);
        return View(album);
    }
    [HttpPost]
    public IActionResult CreateAlbum(Album newAlbum)
    {
        if (ModelState.IsValid)
        {
            //  Insert new Album into Database (2 Steps)
            // 1  Add
            _db.Add(newAlbum);
            // 2 Save
            _db.SaveChanges();
            return RedirectToAction("Privacy");
        }
        // Display Error messages
        return View("Index");
    }
    [HttpPost]
    public IActionResult UpdateAlbum(Album albumToUpdate)
    {
        System.Console.WriteLine($"Album Id : {albumToUpdate.AlbumId}\n CreatedAt : {albumToUpdate.CreatedAt}");
        if (ModelState.IsValid)
        {
            // 1- Update
            Album album = _db.Albums.FirstOrDefault(x => x.AlbumId == albumToUpdate.AlbumId);
            // Mapping
            album.Title = albumToUpdate.Title;
            album.Artist = albumToUpdate.Artist;
            album.ReleaseYear = albumToUpdate.ReleaseYear;
            album.Genre = albumToUpdate.Genre;
            album.PosterUrl = albumToUpdate.PosterUrl;
            album.UpdatedAt = DateTime.Now;
            //  2 - Save
            _db.SaveChanges();
            return RedirectToAction("Privacy");
        }
        return View("Edit");

    }
    [HttpPost]
    public IActionResult DeleteAlbum(int albumId)
    {
        Album? albumToDelete = _db.Albums.FirstOrDefault(a => a.AlbumId == albumId);
        //  1 Delete
        _db.Albums.Remove(albumToDelete);
        //  2 Save
        _db.SaveChanges();
        return RedirectToAction("Privacy");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
