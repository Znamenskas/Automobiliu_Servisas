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
               /* Servisas Servisas = new Servisas("Keturi Ratai", "Kreves pr.83","Vardenis Pavardenis", "Kaunas");
                Specializacija specializacija = new Specializacija("Elektrikas");
                Meistras meistras = new Meistras("Antanas","Antanaitis","Nuotrauka");*/

                //  Ieškoti bet kokių servisų.
                // if (context.Servisas.Any())
                // {
                //     Console.WriteLine("LABAS-LABAS-LABAS");
                //     return;   // DB has been seeded
                // }
                // Console.WriteLine("KRABAS-KRABAS-KRABAS");

                //context.Servisas.AddRange(
                //    new Servisas
                //    {
                //        Pavadinimas = "Keturi Ratai",
                //        Miestas = "Kaunas",
                //        Adresas = "Krėvės pr. 83",
                //        Vadovas = "Vardenis Pavardenis"
                //    },

                //    new Servisas
                //    {
                //        Pavadinimas = "Kardanas",
                //        Miestas = "Alytus",
                //        Adresas = "Birutės g.15",
                //        Vadovas = "Antanas Antanaitis",
                //    },

                //    new Servisas
                //    {
                //        Pavadinimas = "Trunda",
                //        Miestas = "Kaunas",
                //        Adresas = "Neries Krantinė 15",
                //        Vadovas = "Petras Petraitis"

                //    } 

                //);
               // context.SaveChanges();

                // meistrai
               /* if (context.Meistras.Any())
                {
                    return;   // DB has been seeded
                }

                context.Meistras.AddRange(
                    new Meistras

                    {
                        Vardas = "Antanas",
                        Pavarde = "Antanaitis",
                        Nuotrauka = "NUOTRAUKA",
                        
                       // Servisas = new Servisas(1),
                       // Specializacija = new Specializacija(3)


                    },

                    new Meistras
                    {
                        Vardas = "Petras",
                        Pavarde = "Petraitis",
                        Nuotrauka = "Nuotrauka",

                        //Servisas =new Servisas(2),
                       // Specializacija = new Specializacija(2)
                        

                    },

                    new Meistras

                    {
                        Vardas = "Jurgis",
                        Pavarde = "Jurgaitis",
                        Nuotrauka = "Nuotrauka",

                        //Servisas=new Servisas(3),
                       // Specializacija = new Specializacija(3)
                        

                    }
                   );
                context.SaveChanges();

                /* context.Vartotojas.AddRange(
                     new Vartotojas
                     {
                         Slaptazodis = "Kelmas",
                         ElektroninisPastas = "Medis",
                         PrisijungimoVardas = "Vila"
                     }

                     );
                 context.SaveChanges();*/

                // Specializacija
               /* context.Specializacija.AddRange(
                    new Specializacija
                    {
                        Pavadinimas = "Elektrikas"

                    },
                    new Specializacija
                    {
                        Pavadinimas = "Motoristas"
                    },
                    new Specializacija
                    {
                        Pavadinimas = "Skardininkas"
                    }
                );
                context.SaveChanges();*/
            }
        }
    }
}
   

