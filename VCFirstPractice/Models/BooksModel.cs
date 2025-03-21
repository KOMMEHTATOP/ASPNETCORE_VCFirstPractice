using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        
        [NotMapped] //указывает что это поле не должно быть в бд
        public int DisplayNumber { get; set; }

    }
}
