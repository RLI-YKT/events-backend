using System.ComponentModel.DataAnnotations;
using SrcASP.Models.EventModels;

namespace SrcASP.Models.HackathonModels;

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