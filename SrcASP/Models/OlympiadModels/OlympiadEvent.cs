﻿using System.ComponentModel.DataAnnotations;
using SrcASP.Models.EventModels;

namespace SrcASP.Models.OlympiadModels;

public class OlympiadEvent
{
    public int Id { get; set; }
    
    [Required]
    public Event Event { get; set; }
        
    [Required]
    public OlympiadOrg Org { get; set; }
        
    [Required]
    public OlympiadLevel OlympiadLevel { get; set; }
    public string? Opinion { get; set; }
}