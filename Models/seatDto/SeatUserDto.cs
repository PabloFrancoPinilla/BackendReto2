namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SeatUserDto
{

    [Key]
    public int Id { get; set; }
    [Required]
    public int Number { get; set; }
    [Required]

    public double Price { get; set; }
    public string State { get; set; }
    public SessionDto Session{get;set;}
    public SeatUserDto() { }

}
