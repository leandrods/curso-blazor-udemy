﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Peliculas.Server;

#nullable disable

namespace Peliculas.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220328133952_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Peliculas.Shared.Entidades.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("Peliculas.Shared.Entidades.GeneroPelicula", b =>
                {
                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.HasKey("GeneroId", "PeliculaId");

                    b.HasIndex("PeliculaId");

                    b.ToTable("GenerosPeliculas");
                });

            modelBuilder.Entity("Peliculas.Shared.Entidades.Pelicula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("EnCartelera")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Lanzamiento")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Poster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resumen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trailer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Peliculas");
                });

            modelBuilder.Entity("Peliculas.Shared.Entidades.PeliculaActor", b =>
                {
                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.Property<int>("Orden")
                        .HasColumnType("int");

                    b.Property<string>("Personaje")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PeliculaId", "PersonaId");

                    b.HasIndex("PersonaId");

                    b.ToTable("PeliculasActores");
                });

            modelBuilder.Entity("Peliculas.Shared.Entidades.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Biografia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaNacimiento")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("Peliculas.Shared.Entidades.GeneroPelicula", b =>
                {
                    b.HasOne("Peliculas.Shared.Entidades.Genero", "Genero")
                        .WithMany("GeneroPeliculas")
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Peliculas.Shared.Entidades.Pelicula", "Pelicula")
                        .WithMany("GenerosPelicula")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");

                    b.Navigation("Pelicula");
                });

            modelBuilder.Entity("Peliculas.Shared.Entidades.PeliculaActor", b =>
                {
                    b.HasOne("Peliculas.Shared.Entidades.Pelicula", "Pelicula")
                        .WithMany("PeliculaActor")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Peliculas.Shared.Entidades.Persona", "Persona")
                        .WithMany("PeliculaActor")
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pelicula");

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("Peliculas.Shared.Entidades.Genero", b =>
                {
                    b.Navigation("GeneroPeliculas");
                });

            modelBuilder.Entity("Peliculas.Shared.Entidades.Pelicula", b =>
                {
                    b.Navigation("GenerosPelicula");

                    b.Navigation("PeliculaActor");
                });

            modelBuilder.Entity("Peliculas.Shared.Entidades.Persona", b =>
                {
                    b.Navigation("PeliculaActor");
                });
#pragma warning restore 612, 618
        }
    }
}