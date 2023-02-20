using System.ComponentModel.DataAnnotations;

namespace AnimalShelterApi.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    [Required]
    [StringLength(250, ErrorMessage = "Give liddo buddy a name!")]
    public string Name { get; set; }
    [Required]
    [StringLength(50, ErrorMessage = "Must give a brief description!")]
    public string Description { get; set; }
    [Required]
    [StringLength(25, ErrorMessage = "Please define what animal type!")]
    public string Type { get; set; }
    public DateTime Date { get; set; }
  }
}