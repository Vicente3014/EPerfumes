using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EPerfumesFinal.Models
{
    [Table("OrderStatus")]
    public class OrderStatus
    {
        [Key]
        public int StatusID { get; set; }
        [Required]
        public int Status_ID { get; set; }
        [Required, MaxLength(20)]
        public string StatusName { get; set; } = string.Empty;
    }
}
