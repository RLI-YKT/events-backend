﻿using System.ComponentModel.DataAnnotations;

namespace SrcASP.Models.EventModels;

public class EventDate
{
    public int Id { get; set; }
    
    [Required]
    public Event Event { get; set; }
    
    [Required]
    public DateOnly Date { get; set; }
    
    [Required]
    public string Description { get; set; }
}