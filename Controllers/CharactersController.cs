using TheHobbit.Models;
using Microsoft.AspNetCore.Mvc;

namespace TheHobbit.Controllers;

public class CharactersController : Controller
{
    public IActionResult Index()
    {
        return View(CharacterData.All);
    }
}