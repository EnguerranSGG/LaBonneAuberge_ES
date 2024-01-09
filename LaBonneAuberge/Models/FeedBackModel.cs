using System.ComponentModel.DataAnnotations;

namespace LaBonneAuberge.Models;

public class FeedBackModel
{
    [Key]
    public int Id_FeedBack { get; set; }
    public string? Pseudo_FeedBack { get; set; }
    public int Notation_FeedBack { get; set; }
    public string? Email_FeedBack { get; set; }
    public string? Message_FeedBack { get; set; }
}
