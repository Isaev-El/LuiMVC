using System.Net.Mime;
using System.Text;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace LuiMVC;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();
        var app = builder.Build();

        app.UseStaticFiles();
        
        app.UseRouting();
        
        app.MapControllerRoute(
            name:"default",
            pattern:"{controller=Home}/{action=Index}/{id?}"
            );
        
        app.Run();
    }
}