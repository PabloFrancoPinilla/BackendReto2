﻿namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Obra
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Image { get; set; }
    [Required]
    public string Duration { get; set; }
    [Required]
    public string Genre { get; set; }
    [ForeignKey("User")]
    public List<User> Users { get; set; }

    public List<Seat> Seats { get; set; }
    public User User { get; set; }
    public Obra() { }

}
