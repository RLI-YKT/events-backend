using System.ComponentModel.DataAnnotations;

namespace SrcASP.Domain.Models.EventModels;

public class Event
{
    public int Id { get; set; }
    
    [Required]
    public EventType EventType { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public string Description { get; set; }

    // Contacts
    public string? Number { get; set; }
    public string? Mail { get; set; }
    public string? Url { get; set; }
}