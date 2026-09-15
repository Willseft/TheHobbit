namespace TheHobbit.Models;

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Race { get; set; } = "";
    public string HomeLand { get; set; } = "";
    public int Age { get; set; }
}