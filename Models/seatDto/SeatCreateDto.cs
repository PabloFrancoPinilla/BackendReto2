namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SeatCreateDto
{

    [Required]
    public int Number { get; set; }

    [Required]
    public int SalaId { get; set; }

    public int? UserId { get; set; } = 0;
    public double Price { get; set; }
    public string State { get; set; }

    public SeatCreateDto() { }

}