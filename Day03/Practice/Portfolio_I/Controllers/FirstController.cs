using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers;

public class FirstController : Controller
{
    [HttpGet("")]   
    public string First()    
    {
        return "This is my index !";
    }

    [HttpGet("/projects")]   
    public string Second()    
    {
        return "These are my projects";
    }

    [HttpGet("/contact")]   
    public string Third()    
    {
        return "This is my Contact !";
    }
}