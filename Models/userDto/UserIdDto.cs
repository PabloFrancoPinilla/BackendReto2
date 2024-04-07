namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;

public class UserIdDto
{
    [Key]
    public int Id { get; set; }
    public UserIdDto()
    {
    }

}
