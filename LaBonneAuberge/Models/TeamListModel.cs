using System.ComponentModel.DataAnnotations;

namespace LaBonneAuberge.Models;
public class TeamList
{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Job { get; set; }
    public string? Description { get; set; }
    public string? Photo { get; set; }
}
