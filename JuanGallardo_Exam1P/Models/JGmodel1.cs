using System.ComponentModel.DataAnnotations;
namespace JuanGallardo_Examen1P.Models
{
    public class JGmodel1
    {
        public int JGmodel1ID { get; set; }
        [Required]
        public String? Name { get; set; }
        [Range(0.01, 99.99)]
        public decimal? Price { get; set; }
        [Required(ErrorMessage = "Este campo es requerido.")]
        [RegularExpression(@"^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,16}$", ErrorMessage = "La contraseña debe tener entre 8 y 16 caracteres, al menos un dígito, al menos una minúscula y al menos una mayúscula.")]
        public string Contrasenia { get; set; }
        [Range(1, 100)]
        public int Edad { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
