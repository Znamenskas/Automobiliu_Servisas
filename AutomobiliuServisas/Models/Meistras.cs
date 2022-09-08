using System.ComponentModel.DataAnnotations;
namespace AutomobiliuServisas.Models
{
    public class Meistras

    {

        public Meistras()
        {
        }

        public Meistras(string vardas, string pavarde, string nuotrauka)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Nuotrauka = nuotrauka;
        }

        public Meistras(  string vardas, string pavarde, string nuotrauka, Servisas servisas, ICollection<MeistroReitingas> meistroReitingas, Specializacija specializacija)
        {
           
            Vardas = vardas;
            Pavarde = pavarde;
            Nuotrauka = nuotrauka;
            Servisas = servisas;
            MeistroReitingas = meistroReitingas;
            Specializacija = specializacija;
        }

        [Key]
        public int Id { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public string Nuotrauka { get; set; }

        public  Servisas Servisas { get; set; }

        public ICollection<MeistroReitingas> MeistroReitingas { get; set; }

        public Specializacija Specializacija { get; set; }
    }


}
