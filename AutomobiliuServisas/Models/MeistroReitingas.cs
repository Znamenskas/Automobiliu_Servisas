namespace AutomobiliuServisas.Models
{
    public class MeistroReitingas
    {
        public int Id { get; set; }

        public Meistras Meistras { get; set; }

        public Vartotojas Vartotojas { get; set; }

        public int Balas { get; set; }

        public string Komentaras { get; set; }


    }
}
