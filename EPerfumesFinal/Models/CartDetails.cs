using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EPerfumesFinal.Models
{
   
        [Table("CartDetails")]
        public class CartDetails
        {
            [Key]
            public int CartDetailID { get; set; }
            [Required]
            public int ShoppingCartID { get; set; }
            [Required]
            public int BookID { get; set; }
            [Required]
            public int Quantity { get; set; }
            public Perfume Perfume { get; set; }
            public ShoppingCart ShoppingCart { get; set; }
        }
    
}
