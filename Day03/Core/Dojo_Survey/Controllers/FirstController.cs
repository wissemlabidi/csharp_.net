using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers;

public class FirstController : Controller
{
    [HttpGet("/")]
    public ViewResult Index(string Name, string Location, string Language, string Message)
    {
        System.Console.WriteLine($"Your Name : {Name}\nDojo Location : {Location}\nFavorite Language : {Language}\nMessage : {Message}");
        ViewBag.Name = Name;
        ViewBag.Location  = Location;
        ViewBag.Language  = Language;
        ViewBag.Message  = Message;
        return View();
    }

    [HttpPost("process")]
    public IActionResult Process(string Name, string Location, string Language, string Message)
    {
        Console.WriteLine($"From Data\nName: {Name}\nDojo Location : {Location}\nFavorite Language : {Language}\nMessage : {Message}");
        ViewBag.Name = Name;
        ViewBag.Location  = Location;
        ViewBag.Language  = Language;
        ViewBag.Message  = Message;
        return View("Result");
    }
}