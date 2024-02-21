namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string Mail { get; set; }
    public List<Seat> Seats { get; set; }
    public User()
    {
        Seats = new List<Seat>();
    }

}


















































//me pedorreo