using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TheHobbit.Models;
using TheHobbit.Data;

namespace TheHobbit.Controllers;

public class HomeController : Controller
{
    private readonly CharacterContext _context;

    public HomeController(CharacterContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var featured = _context.Characters.FirstOrDefault();
        return View(featured);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}