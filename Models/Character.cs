using System.ComponentModel.DataAnnotations;

namespace TheHobbit.Models;

public class Character
{
    public int Id { get; set; }

    [Required]
    [StringLength(60)]
    public string Name { get; set; } = "";

    public string Race { get; set; } = "";

    public string HomeLand { get; set; } = "";

    [Range(1, 10000)]
    public int Age { get; set; }
}