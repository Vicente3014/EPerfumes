using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EPerfumesFinal.Models
{
    [Table("OrderDetails")]
    public class OrderDetails
    {
        [Key]
        public int OrderDetailsID { get; set; }
        [Required]
        public int OrderID { get; set; }
        [Required]
        public int PerfumeID { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double Price { get; set; }
        public Orders Orders { get; set; }
        public Perfume Perfume { get; set; }
    }
}
