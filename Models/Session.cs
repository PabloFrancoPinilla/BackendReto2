namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Session
{
    [Key]
    public int Id { get; set; }
    [Required]
    public int ObraId { get; set; }
    public Obra Obra { get; set; }
    
    public List<Seat> Seats { get; set; }

    



}
