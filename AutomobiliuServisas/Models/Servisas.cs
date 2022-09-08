using System.ComponentModel.DataAnnotations;
namespace AutomobiliuServisas.Models
{
    public class Servisas
    {
        public Servisas(int id, string pavadinimas, string adresas, string vadovas, string miestas, ICollection<Meistras> meistras)
        {
            Id = id;
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Vadovas = vadovas;
            Miestas = miestas;
            Meistras = meistras;
        }

        public Servisas(string pavadinimas, string adresas, string vadovas, string miestas)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Vadovas = vadovas;
            Miestas = miestas;
        }

        public Servisas(int id)
        {
            Id = id;
        }

        [Key]
        public int Id { get; set; }
        public string Pavadinimas { get; set; }

        public string Adresas { get; set; }
        public string Vadovas { get; set; }
        public string Miestas { get; set; }

        public ICollection<Meistras> Meistras { get; set; }
    }
}
