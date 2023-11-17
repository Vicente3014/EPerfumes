using EPerfumesFinal.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EPerfumesFinal.Models
{
    public class Perfume
    {
        [Key]
        public int Perfume_ID { get; set; }
        [Required(ErrorMessage ="Por favor introduza o nome do perfume")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "O Nome do Perfume deve ter entre 5 e 50 caracteres")]
        [Display(Name = "Nome do Perfume")]
        public string Perfume_Name { get; set; }
        [Required(ErrorMessage ="Por favor introduza o URL da fotografia do perfume")]
        [Display(Name = "Foto do Perfume")]
        public string Perfume_Pic_URL { get; set;}
        [Required(ErrorMessage ="Por favor introduza o tamanho do perfume")]
        [Display(Name = "Tamanho em ml")]
        [Range(50,150)]
        public int Tamanho { get; set; }
        [Display(Name = "Preço(€)")]
        [Required(ErrorMessage ="Por favor introduza o preço do perfume")]
        [Range(0.0,Double.PositiveInfinity)]
        public double Price { get; set; }
        [Required(ErrorMessage ="Por favor escolha o género do perfume")]
        [Display(Name = "Para:")]
        public PerfumeType PerfumeType { get; set; }
        [Required(ErrorMessage ="Por favor escolha um tipo de perfume")]
        [Display(Name = "Tipo de Perfume")]
        public PerfumeVersion PerfumeVersion { get; set; }


        //Marca
        public int? Marca_ID { get; set; }
        public Marca? Marca { get; set; }
        public List<Marca> MarcaList { get; set; }

        public Perfume()
        {
            MarcaList = new List<Marca>();
        }
    }
}
