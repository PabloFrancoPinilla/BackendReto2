namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ReserveCreateDto
{

    [Key]
    public int Id { get; set; }
    public List<int> SeatIds { get; set; }
  

    public int SessionId { get; set; }
  

    public int UserId { get; set; }
   


}
