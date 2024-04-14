using System.ComponentModel.DataAnnotations;
using SrcMvc.Models.EventModels;

namespace SrcMvc.Models.HackathonModels;

public class HackathonEvent
{
    public int Id { get; set; }
        
    [Required]
    public Event Event { get; set; }
        
    [Required]
    public HackathonOrg Org { get; set; }
        
    [Required]
    public string PrizeFund { get; set; }
    
    public IList<string> TechnologicalOrientation { get; set; }
}