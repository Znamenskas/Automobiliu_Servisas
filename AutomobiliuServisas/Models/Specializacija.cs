using System.ComponentModel.DataAnnotations;
namespace AutomobiliuServisas.Models
{
    public class Specializacija

    {
        

        public Specializacija(int id, string pavadinimas, ICollection<Meistras> meistras)
        {
            Id = id;
            Pavadinimas = pavadinimas;
            Meistras = meistras;
        }

        public Specializacija(string pavadinimas)
        {
            Pavadinimas = pavadinimas;
        }

        [Key]
        public int Id { get; set; }
        public string Pavadinimas { get; set; }

        public ICollection<Meistras> Meistras  { get; set; }
    }
}
