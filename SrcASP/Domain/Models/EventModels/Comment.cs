using System.ComponentModel.DataAnnotations;

namespace SrcASP.Domain.Models.EventModels;

public class Comment
{
    public int Id { get; set; }
        
    [Required]
    public Event Event { get; set; }
    
    [Required]
    public string Name { get; set; }
    public int Year { get; set; }
    
    [Required]
    public string Text { get; set; }
    
    [Required]
    public DateTime Date { get; set; }
    
    [Required]
    public MessageStatus Status { get; set; }
}