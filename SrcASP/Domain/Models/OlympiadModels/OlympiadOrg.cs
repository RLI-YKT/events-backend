using System.ComponentModel.DataAnnotations;

namespace SrcASP.Domain.Models.OlympiadModels;

public class OlympiadOrg
{
    public int Id { get; set; }
        
    [Required]
    public string Name { get; set; }
}