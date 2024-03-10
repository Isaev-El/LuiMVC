using LuiMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace LuiMVC.Controllers;

public class CategoriesController : Controller
{
    // GET
    public IActionResult Index()
    {
        var categories = CategoryRepository.GetCategories();
        if (categories is null)
        {
            return NotFound();
        }
        return View(categories);
    }

    public IActionResult Edit(int? id)
    {
        var result = CategoryRepository.GetCategoryById(id.HasValue?id.Value:0);
        return View(result);
    }
}