using LuiMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LuiMVC.Controllers;

public class CategoriesController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Edit(int? id)
    {
        var result = new Category
        {
            CategoryId = id.HasValue?id.Value:0,
        };
        return View(result);
    }
}