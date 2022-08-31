using System.ComponentModel.DataAnnotations;
namespace AutomobiliuServisas.Models
{
    public class Meistras
    {
        [Key]
        public int Id { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public string Nuotrauka { get; set; }
        public int ServisasId { get; set; }
    }
}
