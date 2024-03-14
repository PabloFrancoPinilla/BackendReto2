namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SalaDto
{
    public int Id { get; set; }
    public int Numero {get;set;}
    public int SessionId { get; set; }

    public List<SeatDto> Seats{get;set;}


}