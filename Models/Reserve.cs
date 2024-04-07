namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Reserve
{

    [Key]
    public int Id { get; set; }
    public int SeatId { get; set; }
    public Seat Seat { get; set; }

    public int SessionId { get; set; }
    public Session Session { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    public Reserve(){}

}
