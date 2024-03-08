using Microsoft.AspNetCore.Mvc;

namespace LuiMVC.Controllers;

public class CategoriesController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}