using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Songify.Models;

namespace Songify.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _db;

    public HomeController(ILogger<HomeController> logger, AppDbContext db)
    {
        _logger = logger;
        _db = db;

    }
    // ------------------------------------User Actions-------------------------------
    public IActionResult Index()
    {
        return View();
    }
    [SessionCheck]
    public IActionResult Dashboard()
    {
        List<Album> allAlbums = _db.Albums.Include(a => a.User).ToList();
        return View(allAlbums);
    }
    [HttpPost]
    public IActionResult Register(User user)
    {
        if (ModelState.IsValid)
        {
            bool result = _db.Users.Any(u => u.Email == user.Email);
            if (result)
            {
                ModelState.AddModelError("Email", "Email already in use. Hope by you 🤡.");
                return View("Index");
            }
            else
            {
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                _db.Add(user);
                _db.SaveChanges();
                HttpContext.Session.SetInt32("userId", user.UserId);
                HttpContext.Session.SetString("username", user.Username);
                return RedirectToAction("Dashboard");

            }
        }
        return View("Index");

    }

    [HttpPost]
    public IActionResult Login(LoginUser loginUser)
    {
        if (ModelState.IsValid)
        {
            User? userFromDb = _db.Users.FirstOrDefault(x => x.Email == loginUser.LoginEmail);
            if (userFromDb is not null)
            {
                PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(loginUser, userFromDb.Password, loginUser.LoginPassword);
                if (result == 0)
                {
                    ModelState.AddModelError("LoginPassword", "Wrong Password.");
                    return View("Index");
                }
                HttpContext.Session.SetInt32("userId", userFromDb.UserId);
                HttpContext.Session.SetString("username", userFromDb.Username);
                return RedirectToAction("Dashboard");
            }
            ModelState.AddModelError("LoginEmail", "Email doesn't exist. Try to register.");
            return View("Index");
        }
        return View("Index");
    }

    [HttpPost]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }
    [SessionCheck]
    public IActionResult Profile()
    {
        int idFromSession = (int)HttpContext.Session.GetInt32("userId");
        User user = _db.Users.Include(u => u.MyFavoriteAlbums).FirstOrDefault(u => u.UserId == idFromSession);
        return View(user);
    }
    // ------------------------------------END User Actions-------------------------------

    // !                                    Album Actions                                  
    [SessionCheck]
    public IActionResult AddAlbum()
    {
        return View();
    }

    [SessionCheck]
    public IActionResult AddAlbumV01()
    {
        List<User> allUsers  = _db.Users.ToList();
        ViewBag.AllUsers =allUsers;
        return View();
    }
    [HttpPost]
    public IActionResult CreateAlbum(Album newAlbum)
    {
        if (ModelState.IsValid)
        {
            _db.Add(newAlbum);
            _db.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        // Display Error messages
        return View("AddAlbum");
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    //  - Session check Filter class
    public class SessionCheckAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            int? userId = context.HttpContext.Session.GetInt32("userId");
            if (userId == null)
            {
                context.Result = new RedirectToActionResult("Index", "Home", null);
            }
        }
    }
}
