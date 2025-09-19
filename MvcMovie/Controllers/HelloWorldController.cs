using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    public string Index()
    {
        return "This is my default action...";
    }

    public string Welcome(string name, int numTimes = 1)
    {
        return $"Hello {name}, NumTimes is: {numTimes}";
    }
}
