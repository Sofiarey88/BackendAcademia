﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AcademiaBaile.Migrations
{
    [DbContext(typeof(ACADEMIAContext))]
    [Migration("20240905171451_InicioProyecto")]
    partial class InicioProyecto
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("AcademiaBaile.Models.Clase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Horario")
                        .HasColumnType("longtext");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<int>("RitmoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Clases");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Aprende los pasos básicos de salsa",
                            Horario = "Lunes y Miércoles 18:00-19:00",
                            InstructorId = 1,
                            Nombre = "Clase de Salsa",
                            RitmoId = 1
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Aprende los pasos básicos de bachata",
                            Horario = "Martes y Jueves 19:00-20:00",
                            InstructorId = 2,
                            Nombre = "Clase de Bachata",
                            RitmoId = 2
                        });
                });

            modelBuilder.Entity("AcademiaBaile.Models.Estudiante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Estudiantes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellido = "Pérez",
                            Email = "juan.perez@example.com",
                            FechaNacimiento = new DateTime(1995, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Juan",
                            Telefono = "123456789"
                        },
                        new
                        {
                            Id = 2,
                            Apellido = "Gómez",
                            Email = "ana.gomez@example.com",
                            FechaNacimiento = new DateTime(1998, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Ana",
                            Telefono = "987654321"
                        });
                });

            modelBuilder.Entity("AcademiaBaile.Models.Inscripcion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClaseId")
                        .HasColumnType("int");

                    b.Property<int>("EstudianteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaInscripcion")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Inscripciones");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaseId = 1,
                            EstudianteId = 1,
                            FechaInscripcion = new DateTime(2024, 9, 5, 14, 14, 49, 880, DateTimeKind.Local).AddTicks(2077)
                        },
                        new
                        {
                            Id = 2,
                            ClaseId = 2,
                            EstudianteId = 2,
                            FechaInscripcion = new DateTime(2024, 9, 5, 14, 14, 49, 880, DateTimeKind.Local).AddTicks(2097)
                        });
                });

            modelBuilder.Entity("AcademiaBaile.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Especialidad")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<string>("Telefono")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Instructores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellido = "López",
                            Email = "carlos.lopez@example.com",
                            Especialidad = "Salsa",
                            Nombre = "Carlos",
                            Telefono = "555123456"
                        },
                        new
                        {
                            Id = 2,
                            Apellido = "Rodríguez",
                            Email = "maria.rodriguez@example.com",
                            Especialidad = "Bachata",
                            Nombre = "María",
                            Telefono = "555654321"
                        });
                });

            modelBuilder.Entity("AcademiaBaile.Models.Pago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EstudianteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaPago")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MetodoPago")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Pagos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EstudianteId = 1,
                            FechaPago = new DateTime(2024, 9, 5, 14, 14, 49, 880, DateTimeKind.Local).AddTicks(2145),
                            MetodoPago = "Tarjeta de Crédito",
                            Monto = 50.00m
                        },
                        new
                        {
                            Id = 2,
                            EstudianteId = 2,
                            FechaPago = new DateTime(2024, 9, 5, 14, 14, 49, 880, DateTimeKind.Local).AddTicks(2149),
                            MetodoPago = "Efectivo",
                            Monto = 50.00m
                        });
                });

            modelBuilder.Entity("AcademiaBaile.Models.Ritmo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Ritmos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Un ritmo latino popular",
                            Nombre = "Salsa"
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "Un ritmo romántico y sensual",
                            Nombre = "Bachata"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
