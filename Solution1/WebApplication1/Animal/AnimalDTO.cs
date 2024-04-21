using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Animal
{
    public class CreateAnimalDTO
    {
        [Required] public string Name { get; set; }
    }

    public class UpdateAnimalDTO
    {
        [Required] public string Name { get; set; }
        [Required] public string Description { get; set; }
        [Required] public string CATEGORY { get; set; }
        [Required] public string AREA { get; set; }
    }
}