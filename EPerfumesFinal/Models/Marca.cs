using System.ComponentModel.DataAnnotations;

namespace EPerfumesFinal.Models
{
    public class Marca
    {
        [Key]
        public int Marca_ID { get; set; }

        [Display(Name="Nome da Marca")]
        [Required(ErrorMessage ="Nome da Marca Obrigatório")]
        [StringLength(30, MinimumLength = 4,ErrorMessage ="O Nome da Marca deve ter entre 4 a 30 caracteres")]
        public string Marca_Name { get; set;}

        [Display(Name = "Logo da Marca")]
        [Required(ErrorMessage ="Logo da Marca Obrigatório")]
        public string Marca_Pic_URL { get; set; }

        //Relationships
        public ICollection<Perfume>? Perfumes { get; set; }
    }
}
