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
    public int UserId { get; set; }
    public User User { get; set; }
    public int SessionId { get; set; }
    public Session Session { get; set; }


}
