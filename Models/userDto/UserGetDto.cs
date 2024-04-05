namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class UserGetDto
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Mail { get; set; }
    public UserGetDto()
    {
    }

}
