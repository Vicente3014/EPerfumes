using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EPerfumesFinal.Models
{
    [Table("ShoppingCart")]
    public class ShoppingCart
    {
        [Key]
        public int CartID { get; set; }
        [Required]
        public string UserID { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
