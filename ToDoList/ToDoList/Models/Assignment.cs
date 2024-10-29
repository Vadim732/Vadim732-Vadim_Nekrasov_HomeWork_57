﻿using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models;

public class Assignment
{
    public int Id { get; set; }
    [Required]
    [StringLength(26, MinimumLength = 3)]
    public string Name { get; set; }
    [Required]
    public int Priority { get; set; }
    [Required]
    public int Status { get; set; }
    [Required]
    public string ArtistName { get; set; }
    [Required]
    public string Description { get; set; }
    public DateTime DateCreation { get; set; }
    public DateTime? DateOpening { get; set; }
    public DateTime? DateClosing { get; set; }
}