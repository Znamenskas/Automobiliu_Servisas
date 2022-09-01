using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutomobiliuServisas.Models;

namespace AutomobiliuServisas.Data
{
    public class AutomobiliuServisasContext : DbContext
    {
        public AutomobiliuServisasContext (DbContextOptions<AutomobiliuServisasContext> options)
            : base(options)
        {
        }

        public DbSet<AutomobiliuServisas.Models.Servisas> Servisas { get; set; } = default!;

        public DbSet<AutomobiliuServisas.Models.Meistras>? Meistras { get; set; }

        public DbSet<AutomobiliuServisas.Models.Specializacija>? Specializacija { get; set; }

        public DbSet<AutomobiliuServisas.Models.Vartotojas>? Vartotojas { get; set; }
    }
}
