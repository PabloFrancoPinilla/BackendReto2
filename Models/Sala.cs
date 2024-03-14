namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Sala
{

    [Key]
    public int Id { get; set; }

    public int Numero { get; set; }

    public int SessionId { get; set; }

    public List<Seat> Seats { get; set; }
    public List<Session> Sessions { get; set; }
    public Sala() { }

}
