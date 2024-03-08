using Microsoft.AspNetCore.Mvc;

namespace LuiMVC.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}