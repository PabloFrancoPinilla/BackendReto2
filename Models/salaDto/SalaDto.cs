namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SalaDto
{
    public int Id { get; set; }
    public int Number { get; set; }
    public int SessionId { get; set; }
    public List<SessionRDto> Sessions { get; set; }
    public List<SeatDto> Seats { get; set; }


}