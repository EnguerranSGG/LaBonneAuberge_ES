using System.ComponentModel.DataAnnotations;

namespace LaBonneAuberge.Models;
public class Menu
{   
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }

    public int CategoryId {get;set; }
    public Category? Category { get; set; }

    public string? Img {get;set;}
}