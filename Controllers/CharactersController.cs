
using TheHobbit.Models;
using TheHobbit.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TheHobbit.Controllers;

public class CharactersController : Controller
{
    private readonly CharacterContext _context;

    public CharactersController(CharacterContext context)
    {
        _context = context;
    }

    // GET: Characters
    public IActionResult Index()
    {
        return View(_context.Characters.ToList());
    }

    // GET: Characters/Details/5
    public IActionResult Details(int id)
    {
        var character = _context.Characters.FirstOrDefault(c => c.Id == id);

        if (character == null)
        {
            return NotFound();
        }

        return View(character);
    }

    // GET: Characters/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Characters/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
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

    // GET: Characters/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var character = await _context.Characters.FindAsync(id);

        if (character == null)
        {
            return NotFound();
        }

        return View(character);
    }

    // POST: Characters/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(
        int id,
        [Bind("Id,Name,Race,HomeLand,Age,Description")] Character character)
    {
        if (id != character.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(character);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterExists(character.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToAction(nameof(Index));
        }

        return View(character);
    }

    // GET: Characters/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var character = await _context.Characters
            .FirstOrDefaultAsync(m => m.Id == id);

        if (character == null)
        {
            return NotFound();
        }

        return View(character);
    }

    // POST: Characters/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var character = await _context.Characters.FindAsync(id);

        if (character != null)
        {
            _context.Characters.Remove(character);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));
    }

    // Helper method
    private bool CharacterExists(int id)
    {
        return _context.Characters.Any(e => e.Id == id);
    }
}
