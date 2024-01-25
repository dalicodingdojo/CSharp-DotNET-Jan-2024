using Microsoft.AspNetCore.Mvc;


namespace FirstWebApp.Controllers;

public class FirstController : Controller
{
    // Routes 
    /*
    1 - url ('/' , '/users/1')
    2 - method (GET, POST)
    3 - associated function
    app.route('/users', methods=["GET"])
    def users():
        return render_template('users.html')
    */

    // Method
    [HttpGet]
    //  ('/home')
    [Route("home")]
    public string Home()
    {
        return "Hello from Home Route in the First Controller";
    }

    [HttpGet]
    [Route("")]
    public string FirstRoute()
    {
        return "<h1>Welcome To First Web App 🥳</h1>";
    }

    [HttpGet("params/{username}/{age}")]
    public string Params(string username, int age)
    {
        return $"Username is {username}\n Age : {age} years old.";
    }
    [HttpGet("index")]
    public ViewResult Index()
    {
        return View("Index");
    }
    [HttpGet("dashboard")]
    public ViewResult Dashboard()
    {
        return View();
    }

    [HttpPost("process")]
    public IActionResult Process(string username, int age)
    {
        if(username is null)
        {
             return RedirectToAction("Dashboard");
        }
        Console.WriteLine($"User : {username} -- Age {age}");
        ViewBag.Username = username;
        ViewBag.Age = age;
        return View("Index");
    }
}