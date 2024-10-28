using System.ComponentModel.DataAnnotations;
namespace JuanGallardo_Examen1P.Models
{
    public class JGmodel1
    {
    public int JGmodel1ID { get; set;}
    [Required]
    public String? Name { get; set; }
    [Range(0.01,99.99)]
    public decimal? Price { get; set; } 
    
    public DateTime? CreatedDate { get; set;}
    }
}

