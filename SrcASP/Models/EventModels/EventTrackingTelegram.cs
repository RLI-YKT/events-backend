using System.ComponentModel.DataAnnotations;

namespace SrcASP.Models.EventModels;

public class EventTrackingTelegram
{
    public int Id { get; set; }
    
    [Required]
    public Event Event { get; set; }
    
    [Required]
    public string TelegramUserName { get; set; }
}