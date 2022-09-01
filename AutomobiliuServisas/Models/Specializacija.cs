using System.ComponentModel.DataAnnotations;
namespace AutomobiliuServisas.Models
{
    public class Specializacija
    {
        [Key]
        public int Id { get; set; }
        public string Pavadinimas { get; set; }

        public ICollection<Meistras> Meistras  { get; set; }
    }
}
