namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Seat
{

    [Key]
    public int Id { get; set; }
    [Required]
    public int Number { get; set; }
    [Required]

    public double Price { get; set; }

    public string State { get; set; }
    //Clave Foranea Session
    public int SalaId { get; set; }
    public Sala Sala { get; set; }
    public Seat() { }

}
