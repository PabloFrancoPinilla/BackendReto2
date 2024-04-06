namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ReserveDto
{

    [Key]
    public int Id { get; set; }

    public SeatDto Seat { get; set; }

   
    public SessionDto Session { get; set; }

    
    public User User { get; set; }

    public ReserveDto(){}

}
