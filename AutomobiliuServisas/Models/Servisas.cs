using System.ComponentModel.DataAnnotations;
namespace AutomobiliuServisas.Models
{
    public class Servisas
    {
        [Key]
        public int Id { get; set; }
        public string Pavadinimas { get; set; }

        public string Adresas { get; set; }
        public string Vadovas { get; set; }
        public string Miestas { get; set; }
    }
}
