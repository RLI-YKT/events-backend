using System.ComponentModel.DataAnnotations;

namespace SrcASP.Domain.Models.EventModels;

public class Admin
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public string Login { get; set; }
    
    [Required]
    public string Password { get; set; }
}