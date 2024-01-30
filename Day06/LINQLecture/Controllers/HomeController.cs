using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LINQLecture.Models;

namespace LINQLecture.Controllers;

public class HomeController : Controller
{
    public static Game[] Games = new[]{
        new Game {Title = "Elden Ring", Price=69.99, Genre= "Action RPG", Rating="M", Platform = "PC"},
        new Game {Title="League of Legends", Price=0.00, Genre="MOBA", Rating="T", Platform="PC"},
        new Game {Title="World of Warcraft", Price=49.99, Genre="MMORPG", Rating="T", Platform="PC"},
        new Game {Title="Elder Scrolls Online", Price=19.99, Genre="Action RPG", Rating="M", Platform="PC"},
        new Game {Title="Smite", Price=0.00, Genre="MOBA", Rating="T", Platform="All"},
        new Game {Title="Overwatch", Price=49.00, Genre="First-person Shooter", Rating="T", Platform="PC"},
        new Game {Title="Scarlet Nexus", Price=69.99, Genre="Action JRPG", Rating="T", Platform="All"},
        new Game {Title="Wonderlands", Price=69.99, Genre="RPG FPS", Rating="M", Platform="All"},
        new Game {Title="Rocket League", Price=19.99, Genre="Sports", Rating="E", Platform="All"},
        new Game {Title="StarCraft", Price=29.99, Genre="RTS", Rating="T", Platform="PC"},
        new Game {Title="God of War", Price=39.99, Genre="Action-adventure ", Rating="M", Platform="PC"},
        new Game {Title="Doki Doki Literature Club Plus!", Price=15.00, Genre="Casual", Rating="E", Platform="PC"},
        new Game {Title="Red Dead Redemption", Price=49.99, Genre="Action adventure", Rating="M", Platform="All"},
        new Game {Title = "FIFA 23", Price = 199.99, Genre ="Sports", Rating = "A", Platform = "All"},
        new Game {Title = "Call Of Duty", Price = 299.99, Genre  = "Action", Rating = "A", Platform = "PC"},
        new Game {Title = "PES", Price = 129.99, Genre  = "Sports", Rating = "A", Platform = "All"},
        new Game {Title = "Battlefield", Price = 59.99, Genre = "MOBA", Rating = "B"},
        new Game {Title="My Little Pony A Maretime Bay Adventure", Price=39.99, Genre="Adventure", Rating="E",Platform="All"},
        new Game {Title="Fallout New Vegas", Price=15.00, Genre="Open World RPG", Rating="M", Platform="PC"},
        new Game {Title="BattalField", Price=59.99, Genre="MOBA", Rating="B"},
        new Game {Title = "Cyberpunk 2077", Price = 49.99, Genre = "Action RPG", Rating = "M", Platform = "All"},
        new Game {Title = "Assassin's Creed Valhalla", Price = 59.99, Genre = "Action RPG", Rating = "M", Platform = "All"},
        new Game {Title = "Fortnite", Price = 0.00, Genre = "Battle Royale", Rating = "T", Platform = "All"},
        new Game {Title = "Minecraft", Price = 29.99, Genre = "Sandbox", Rating = "E10+", Platform = "All"},
        new Game {Title = "The Legend of Zelda: Breath of the Wild", Price = 59.99, Genre = "Action-adventure", Rating = "E10+", Platform = "Nintendo Switch"},
        new Game {Title = "Halo Infinite", Price = 59.99, Genre = "First-person Shooter", Rating = "T", Platform = "Xbox"},
        new Game {Title = "Among Us", Price = 4.99, Genre = "Party Game", Rating = "T", Platform = "All"},
        new Game {Title = "Apex Legends", Price = 0.00, Genre = "Battle Royale", Rating = "T", Platform = "All"},
        new Game {Title = "The Witcher 3: Wild Hunt", Price = 39.99, Genre = "Action RPG", Rating = "M", Platform = "All"},
        new Game {Title = "Persona 5", Price = 49.99, Genre = "JRPG", Rating = "M", Platform = "PlayStation"},
        new Game {Title = "Dark Souls III", Price = 39.99, Genre = "Action RPG", Rating = "M", Platform = "All"}
    };
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        /*
            All Queries results will be displayed in the Index View
            To transfer data we will use ViewBag
        */
        // - 1  Display all Games : GET ALL
        // 1 - all Games as List<Game>
        List<Game> AllGamesList = Games.ToList();
        ViewBag.AllGames = AllGamesList;
        // 2 - all Games as IEnumerable<Game>
        IEnumerable<Game> AllGamesIEnumerable = Games;
        ViewBag.AllGamesIEnumerable = AllGamesIEnumerable;

        // - 2 All PC Games
        List<Game> AllPcGames = Games.Where(game => game.Platform == "PC").ToList();
        ViewBag.AllPcGames = AllPcGames;
        // -  3 All Free Games
        List<Game> AllFreeGames = Games.Where(y => y.Price == 0.0).ToList();
        ViewBag.AllFreeGames = AllFreeGames;
        // - 4 First 3 Games
        List<Game> FirstThreeGames = Games.Take(3).ToList();
        ViewBag.FirstThreeGames = FirstThreeGames;
        // - 5 First 3 Games that can be Played in All Platforms
        List<Game> FirstThreeAllPlatform = Games.Where(u => u.Platform == "All").Take(3).ToList();
        ViewBag.FirstThreeAllPlatform = FirstThreeAllPlatform;
        // - 6 All Games Ordered By Title
        List<Game> AllGamesOrderedByTitle = Games.OrderBy(c => c.Title).ToList();
        ViewBag.AllGamesOrderedByTitle = AllGamesOrderedByTitle;
        List<Game> AllGamesOrderedByTitleDescending = Games.OrderByDescending(c => c.Title).ToList();
        ViewBag.AllGamesOrderedByTitleDescending = AllGamesOrderedByTitleDescending;
        // - 7 All Games ordered by Title & Price
        List<Game> GamesOrderedTitlePrice = Games.OrderBy(i => i.Title).OrderBy(j => j.Price).ToList();
        ViewBag.GamesOrderedTitlePrice = GamesOrderedTitlePrice;

        // - 8 All Games ordered by Price & Title
        List<Game> GamesOrderedPriceTitle = Games.OrderBy(i => i.Price).OrderBy(j => j.Title).ToList();
        ViewBag.GamesOrderedPriceTitle = GamesOrderedPriceTitle;
        // - 9 My Favorite Game
        Game MyFavoriteGame = Games.FirstOrDefault(h => h.Title == "FIFA 23");
        ViewBag.MyFavoriteGame = MyFavoriteGame;
        //- 10 All Games Titles
        List<string> AllGamesTitles = Games.Select(k => k.Title).ToList();
        ViewBag.AllGamesTitles = AllGamesTitles;
        // - 11 Most Expensive Game
        double MostExpensiveGamePrice = Games.Max(f => f.Price);
        ViewBag.MostExpensiveGamePrice = MostExpensiveGamePrice;
        // - 12 PES Exist or Not ?

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
}
