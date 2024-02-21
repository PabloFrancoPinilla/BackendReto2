namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Seat
{

    [Key]
    public int Id { get; set; }
    [Required]
    public string Number { get; set; }
    [Required]
    public string State {get; set;}
    //Clave Foranea User
    public int UserId { get; set; }
    public User User { get; set; }
    //Clave Foranea Session
    public int SessionId { get; set; }
    public Session Session { get; set; }

    public Seat(){}

}
