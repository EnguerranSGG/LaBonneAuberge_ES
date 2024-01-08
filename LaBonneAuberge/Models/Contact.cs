using System.ComponentModel.DataAnnotations;

namespace LaBonneAuberge.Models;

public class Contact
{    
    [Key]
    public int Id { get; set; }
    public string? Email{get; set;} 
    public string? Message{get;set;}
}