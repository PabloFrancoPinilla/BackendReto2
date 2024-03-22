namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SeatSalaDto
{

    [Key]
    public int Id { get; set; }

    [Required]
    public int Number { get; set; }

    public int? UserId { get; set; }

    public double Price { get; set; }
    public string State { get; set; }




    public SeatSalaDto() { }

}