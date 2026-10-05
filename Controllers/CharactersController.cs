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

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Character character)
    {
        if (!ModelState.IsValid)
        {
            return View(character);
        }

        character.Id = CharacterData.All.Max(c => c.Id) + 1;
        CharacterData.All.Add(character);

        return RedirectToAction(nameof(Index));
    }
}