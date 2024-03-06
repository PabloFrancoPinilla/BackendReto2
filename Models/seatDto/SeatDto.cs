namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SeatDto
{

    [Key]
    public int Id { get; set; }

    [Required]
    public string Number { get; set; }

}