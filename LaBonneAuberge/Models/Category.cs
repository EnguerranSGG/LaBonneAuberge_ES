using System.ComponentModel.DataAnnotations;

namespace LaBonneAuberge.Models;

public class Category
{   
    [Key]
    public int Id { get; set; }
    public string? Nom { get; set; }

    public ICollection<Menu>? Menus { get; set; }
}