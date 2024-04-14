using System.ComponentModel.DataAnnotations;
using SrcASP.Models.EventModels;

namespace SrcASP.Models.OlympiadModels;

public class UniversityOlympiad
{
    public int Id { get; set; }
        
    [Required]
    public University University { get; set; }
        
    [Required]
    public Event Event { get; set; }
        
    [Required]
    public OlympiadBenefit Benefit { get; set; }
}