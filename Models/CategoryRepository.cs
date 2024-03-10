using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.VisualBasic;

namespace LuiMVC.Models;

public static class CategoryRepository
{
    public static List<Category> _categories = new List<Category>()
    {
        new Category(){CategoryId = 1, Name = "Seafood", Descriptions = "In sea"},
        new Category(){CategoryId = 2, Name = "Meat", Descriptions = "Eats grass"},
        new Category(){CategoryId = 3, Name = "Milk", Descriptions = "Milked from a cow"},
    };

    public static void AddCategory(Category category)
    {
        var maxId = _categories.Max(x=>x.CategoryId);
        category.CategoryId = maxId + 1;
        _categories.Add(category);
    }

    public static Category[] GetCategories() => _categories.ToArray();

    public static Category GetCategoryById(int? id)
    {
        var result=_categories.FirstOrDefault(x => x.CategoryId == id);
        if (result==null)
        {
            return null!;
        }

        return new Category
        {
            CategoryId = result.CategoryId,
            Name = result.Name,
            Descriptions = result.Descriptions
        };
    }

    public static void UpdateCategory(int id,Category? category)
    {
        if (id!=category!.CategoryId) return;
        
        var result = GetCategoryById(id);
        if (result!=null)
        {
            result.Descriptions = category.Descriptions;
            result.Name = category.Name;
        }
    }

    public static void DeleteCategory(int id)
    {
        var result = GetCategoryById(id);
        if (result!=null)
        {
            _categories.Remove(result);
        }
    }
}