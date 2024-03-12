namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SeatCreateDto
{

    [Required]
    public int Number { get; set; }

    [Required]
    public int SessionId { get; set; }

    public int? UserId { get; set; }

    public string State { get; set; }

    public SeatCreateDto() { }

}