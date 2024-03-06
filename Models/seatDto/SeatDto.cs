namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SeatDto
{

    [Key]
    public int Id { get; set; }

    [Required]
    public string Number { get; set; }

    [Required]
    public int SessionId { get; set; }

    public int? UserId { get; set; }

    public string State { get; set; }

    public SessionDto Session { get; set; }


    public SeatDto() { }

}