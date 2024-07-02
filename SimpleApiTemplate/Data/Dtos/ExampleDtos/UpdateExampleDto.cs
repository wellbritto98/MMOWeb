﻿using System.ComponentModel.DataAnnotations;

namespace SimpleApiTemplate.Data.Dtos.ExampleDtos;

public class UpdateExampleDto : BaseDto
{

    [Required]
    public string Name { get; set; }
    [Required]
    public string Nickname { get; set; }

}