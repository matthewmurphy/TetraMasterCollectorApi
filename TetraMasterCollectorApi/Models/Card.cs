using System.ComponentModel.DataAnnotations;

namespace TetraMasterCollectorApi.Models
{
  public class Card
  {
    public int Id { get; set; }

    public required string Name { get; set; }

    [RegularExpression("^[0-9A-F][PMXA][0-9A-F]{2}$")]
    public required string InitialStats { get; set; }

    public string[]? ObtainedFrom { get; set; }

    public bool Missable { get; set; } = false;

    public string? Image { get; set; }
  }
}
