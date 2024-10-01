using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;

namespace CodeFirstBasic.Data.Entities
{
    [Table("Games")]
    public class Game
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string Platform { get; set; }

        [Required]
        [IntegerValidator(MinValue = 0,MaxValue=10)]
        public decimal Rating { get; set; }
    }
}
