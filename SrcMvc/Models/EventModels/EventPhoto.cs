using System.ComponentModel.DataAnnotations;

namespace SrcMvc.Models.EventModels;

public class EventPhoto
{
    public int Id { get; set; }
    
    [Required]
    public Event Event { get; set; }
    
    [Required]
    public string PhotoPath { get; set; }
}