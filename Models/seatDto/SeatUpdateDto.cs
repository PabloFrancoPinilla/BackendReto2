namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SeatUpdateDto
{

    [Key]
    public int Id { get; set; }
    [Required]
    public int Number { get; set; }
    [Required]

    public double Price { get; set; }
    public string State { get; set; }
    public int? UserId { get; set; }
    public int SalaId { get; set; }
    public SeatUpdateDto() { }

}
