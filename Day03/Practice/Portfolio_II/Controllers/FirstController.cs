using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers;

public class FirstController : Controller
{
    [HttpGet("")]   
    public ViewResult AboutMe()    
    {
        return View();
    }

    [HttpGet("/projects")]   
    public ViewResult MyProjectsa
    ()    
    {
        return View();
    }

    [HttpGet("/contact")]   
    public ViewResult ContactMe()    
    {
        return View();
    }
}