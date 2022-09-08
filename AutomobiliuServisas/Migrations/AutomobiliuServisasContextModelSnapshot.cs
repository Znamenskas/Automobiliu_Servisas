﻿// <auto-generated />
using AutomobiliuServisas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutomobiliuServisas.Migrations
{
    [DbContext(typeof(AutomobiliuServisasContext))]
    partial class AutomobiliuServisasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AutomobiliuServisas.Models.Meistras", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nuotrauka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pavarde")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServisasId")
                        .HasColumnType("int");

                    b.Property<int>("SpecializacijaId")
                        .HasColumnType("int");

                    b.Property<string>("Vardas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ServisasId");

                    b.HasIndex("SpecializacijaId");

                    b.ToTable("Meistras");
                });

            modelBuilder.Entity("AutomobiliuServisas.Models.MeistroReitingas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Balas")
                        .HasColumnType("int");

                    b.Property<string>("Komentaras")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MeistrasId")
                        .HasColumnType("int");

                    b.Property<int>("VartotojasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MeistrasId");

                    b.HasIndex("VartotojasId");

                    b.ToTable("MeistroReitingas");
                });

            modelBuilder.Entity("AutomobiliuServisas.Models.Servisas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adresas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Miestas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pavadinimas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vadovas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Servisas");
                });

            modelBuilder.Entity("AutomobiliuServisas.Models.Specializacija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Pavadinimas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Specializacija");
                });

            modelBuilder.Entity("AutomobiliuServisas.Models.Vartotojas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ElektroninisPastas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrisijungimoVardas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slaptazodis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vartotojas");
                });

            modelBuilder.Entity("AutomobiliuServisas.Models.Meistras", b =>
                {
                    b.HasOne("AutomobiliuServisas.Models.Servisas", "Servisas")
                        .WithMany("Meistras")
                        .HasForeignKey("ServisasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutomobiliuServisas.Models.Specializacija", "Specializacija")
                        .WithMany("Meistras")
                        .HasForeignKey("SpecializacijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Servisas");

                    b.Navigation("Specializacija");
                });

            modelBuilder.Entity("AutomobiliuServisas.Models.MeistroReitingas", b =>
                {
                    b.HasOne("AutomobiliuServisas.Models.Meistras", "Meistras")
                        .WithMany("MeistroReitingas")
                        .HasForeignKey("MeistrasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutomobiliuServisas.Models.Vartotojas", "Vartotojas")
                        .WithMany("MeistroReitingas")
                        .HasForeignKey("VartotojasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meistras");

                    b.Navigation("Vartotojas");
                });

            modelBuilder.Entity("AutomobiliuServisas.Models.Meistras", b =>
                {
                    b.Navigation("MeistroReitingas");
                });

            modelBuilder.Entity("AutomobiliuServisas.Models.Servisas", b =>
                {
                    b.Navigation("Meistras");
                });

            modelBuilder.Entity("AutomobiliuServisas.Models.Specializacija", b =>
                {
                    b.Navigation("Meistras");
                });

            modelBuilder.Entity("AutomobiliuServisas.Models.Vartotojas", b =>
                {
                    b.Navigation("MeistroReitingas");
                });
#pragma warning restore 612, 618
        }
    }
}
