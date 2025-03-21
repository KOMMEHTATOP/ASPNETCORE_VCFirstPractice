using System.ComponentModel.DataAnnotations;

namespace VCFirstPractice.Models
{
    public class BooksModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Range(0.1, double.MaxValue, ErrorMessage ="Значение должно быть больше 0")]
        public double Price { get; set; }

    }
}
