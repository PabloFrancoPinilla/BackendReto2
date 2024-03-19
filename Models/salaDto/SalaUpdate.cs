namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SalaUpdateDto
{
    public int Id { get; set; }
    public int Numero {get;set;}
    public int SessionId { get; set; }
    public List<Seat> Seats {get; set;}


}