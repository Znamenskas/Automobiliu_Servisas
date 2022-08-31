using AutomobiliuServisas.Data;
using Microsoft.EntityFrameworkCore;

namespace AutomobiliuServisas.Models
{
    public class SeedDatacs
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AutomobiliuServisasContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AutomobiliuServisasContext>>()))
            {
                //  Ieškoti bet kokių servisų.
               /* if (context.Servisas.Any())
                {
                    Console.WriteLine("LABAS-LABAS-LABAS");
                    return;   // DB has been seeded
                }
                Console.WriteLine("KRABAS-KRABAS-KRABAS");

                context.Servisas.AddRange(
                    new Servisas
                    {
                        Pavadinimas ="Keturi Ratai",
                        Miestas ="Kaunas",
                        Adresas ="Krėvės pr. 83",
                        Vadovas ="Vardenis Pavardenis"
                    },

                    new Servisas
                    {
                        Pavadinimas ="Kardanas",
                        Miestas ="Alytus",
                        Adresas ="Birutės g.15",
                        Vadovas ="Antanas Antanaitis",
                    },

                    new Servisas
                    {
                        Pavadinimas ="Trunda",
                        Miestas ="Kaunas",
                        Adresas ="Neries Krantinė 15",
                        Vadovas ="Petras Petraitis"
                    }
                    
               
                    


                 );*/  
                

                if(context.Meistras.Any())

                {
                    Console.WriteLine("Servisas");
                    return;   // DB has been seeded
                }
                Console.WriteLine("Meistras");

                context.Meistras.AddRange(
                    new Meistras
                    {
                        Vardas = "Antanas",
                        Pavarde ="Antanaitis",
                        Nuotrauka ="NUOTRAUKA",
                        ServisasId = 1
                        
                    },

                    new Meistras
                    {
                        Vardas = "Petras",
                        Pavarde ="Petraitis",
                        Nuotrauka ="Nuotrauka",
                        ServisasId = 2
                        
                    },

                    new Meistras
                    
                    {
                        Vardas = "Jurgis",
                        Pavarde = "Jurgaitis",
                        Nuotrauka = "Nuotrauka",
                        ServisasId = 3
                        
                    }
                    );
                context.SaveChanges();

                
            }
        }
    }
}
   

