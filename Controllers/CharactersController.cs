using TheHobbit.Models;
using Microsoft.AspNetCore.Mvc;

namespace TheHobbit.Controllers;

public class CharactersController : Controller
{
    public IActionResult Index()
    {
        return View(CharacterData.All);
    }

    public IActionResult Details(int id)
    {
        var character = CharacterData.All.FirstOrDefault(c => c.Id == id);

        if (character == null)
        {
            return NotFound();
        }

        return View(character);
    }
}