namespace TeatroBack.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ObraCreateDto
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Image { get; set; }
    [Required]
    public string Duration { get; set; }
    [Required]
    public string Genre { get; set; }
    [Required]
    public string Description { get; set; }
    public ObraCreateDto() { }

}