namespace TheHobbit.Models;

public static class CharacterData
{
    public static List<Character> All { get; } = new()
    {
        new Character { Id = 1, Name = "Bilbo Baggins", Race = "Hobbit", HomeLand = "The Shire", Age = 50 },
        new Character { Id = 2, Name = "Gandalf", Race = "Maia", HomeLand = "Valinor", Age = 2000 },
        new Character { Id = 3, Name = "Thorin Oakenshield", Race = "Dwarf", HomeLand = "Erebor", Age = 195 },
        new Character { Id = 4, Name = "Gollum", Race = "Hobbit", HomeLand = "The Misty Mountains", Age = 589 },
        new Character { Id = 5, Name = "Smaug", Race = "Dragon", HomeLand = "Erebor", Age = 171 },
    };
}