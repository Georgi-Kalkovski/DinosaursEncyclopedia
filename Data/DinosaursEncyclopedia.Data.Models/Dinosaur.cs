namespace DinosaursEncyclopedia.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Dinosaur
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Period { get; set; }

        [Required]
        public string Diet { get; set; }
    }
}
