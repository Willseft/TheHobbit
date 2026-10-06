using TheHobbit.Models;
using TheHobbit.Data;
using Microsoft.AspNetCore.Mvc;

namespace TheHobbit.Controllers;

public class CharactersController : Controller
{
    private readonly CharacterContext _context;

    public CharactersController(CharacterContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View(_context.Characters.ToList());
    }

    public IActionResult Details(int id)
    {
        var character = _context.Characters.FirstOrDefault(c => c.Id == id);

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

        _context.Characters.Add(character);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }
}