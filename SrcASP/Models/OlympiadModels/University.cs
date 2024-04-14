﻿using System.ComponentModel.DataAnnotations;

namespace SrcASP.Models.OlympiadModels;

public class University
{
    public int Id { get; set; }
        
    [Required]
    public string Name { get; set; }
}