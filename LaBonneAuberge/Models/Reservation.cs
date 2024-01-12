using System.ComponentModel.DataAnnotations;

namespace LaBonneAuberge.Models;
public class Reservation
{
    public int Id { get; set; }

    [StringLength(10)]
    public string? Nom { get; set; }
    
    public DateOnly Date {get; set;}

    public TimeOnly Time {get; set;}
    public int NombreAdultes { get; set; }
    public int NombreEnfants { get; set; }
    public int NumTel { get; set; }
    public string? Email { get; set; }
    public string? Message { get; set; }
    public bool Anniversaire { get; set; }

}
