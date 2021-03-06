﻿// <auto-generated />
using System;
using GestionEscolar.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestionEscolar.Datos.Migrations
{
    [DbContext(typeof(GestionEscolarContexto))]
    [Migration("20200722152952_MigracionInicial")]
    partial class MigracionInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GestionEstudiantes.Modelos.Estudiante", b =>
                {
                    b.Property<string>("TarjetaIdentidad")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("TarjetaIdentidad");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("GestionEstudiantes.Modelos.Grupo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CedulaProfesor")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<int>("IdMateria")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdMateria");

                    b.HasIndex("CedulaProfesor", "IdMateria")
                        .IsUnique();

                    b.ToTable("Grupos");
                });

            modelBuilder.Entity("GestionEstudiantes.Modelos.Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("GestionEstudiantes.Modelos.MateriaEstudiante", b =>
                {
                    b.Property<int>("IdGrupo")
                        .HasColumnType("int");

                    b.Property<string>("TarjetaIdentidadEstudiante")
                        .HasColumnType("VARCHAR(50)")
                        .HasMaxLength(50);

                    b.Property<float?>("CalificacionPrimerPeriodo")
                        .HasColumnType("real");

                    b.Property<float?>("CalificacionSegundoPeriodo")
                        .HasColumnType("real");

                    b.Property<float?>("CalificacionTercerPeriodo")
                        .HasColumnType("real");

                    b.HasKey("IdGrupo", "TarjetaIdentidadEstudiante");

                    b.HasIndex("TarjetaIdentidadEstudiante");

                    b.ToTable("MateriasEstudiantes");
                });

            modelBuilder.Entity("GestionEstudiantes.Modelos.Profesor", b =>
                {
                    b.Property<string>("Cedula")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Cedula");

                    b.ToTable("Profesores");
                });

            modelBuilder.Entity("GestionEstudiantes.Modelos.Grupo", b =>
                {
                    b.HasOne("GestionEstudiantes.Modelos.Profesor", "Profesor")
                        .WithMany("Grupos")
                        .HasForeignKey("CedulaProfesor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestionEstudiantes.Modelos.Materia", "Materia")
                        .WithMany("Grupos")
                        .HasForeignKey("IdMateria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GestionEstudiantes.Modelos.MateriaEstudiante", b =>
                {
                    b.HasOne("GestionEstudiantes.Modelos.Grupo", "Grupo")
                        .WithMany("MateriasEstudiantes")
                        .HasForeignKey("IdGrupo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GestionEstudiantes.Modelos.Estudiante", "Estudiante")
                        .WithMany("Materias")
                        .HasForeignKey("TarjetaIdentidadEstudiante")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
