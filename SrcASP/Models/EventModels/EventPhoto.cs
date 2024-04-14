using System.ComponentModel.DataAnnotations;

namespace SrcASP.Models.EventModels;

public class EventPhoto
{
    public int Id { get; set; }
    
    [Required]
    public Event Event { get; set; }
    
    [Required]
    public string PhotoPath { get; set; }
}