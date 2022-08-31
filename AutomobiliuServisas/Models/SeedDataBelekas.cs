using AutomobiliuServisas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Linq;

namespace AutomobiliuServisas.Models
{
   public static class SeedDataBelekas
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AutomobiliuServisasContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AutomobiliuServisasContext>>()))
            {
                // Look for any movies.
                if (context.Meistras.Any()) 
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
                        Nuotrauka = "",
                        ServisasId = 1 
                    },

                    new Meistras
                    {
                        Vardas = "Petras",
                        Pavarde = "Petraitis",
                        Nuotrauka = "",
                        ServisasId = 2
                    },

                    new Meistras
                    {
                        Vardas = "Jurgis",
                        Pavarde = "Jurgaitis",
                        Nuotrauka = "",
                        ServisasId = 3
                    }

                    
                );
                context.SaveChanges();
            }
        }
    }
}


