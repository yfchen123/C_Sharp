using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Chapter12
{
    public class Customer
    {
        [Key]
        [Column(TypeName = "nchar (5)")]
        [RegularExpression("[A-Z]{5}")]
        public string CustomerId { get; set; } = null!;
    }
}
