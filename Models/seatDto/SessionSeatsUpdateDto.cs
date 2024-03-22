namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SessionSeatsUpdateDto
{

     public List<SeatUpdateDto> Seats { get; set; }

}
