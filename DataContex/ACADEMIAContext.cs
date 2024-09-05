using AcademiaBaile.Models;
using Microsoft.EntityFrameworkCore;
using System;

public class ACADEMIAContext : DbContext
{
    public ACADEMIAContext(DbContextOptions<ACADEMIAContext> options)
        : base(options)
    {
    }

    public DbSet<Estudiante> Estudiantes { get; set; }
    public DbSet<Instructor> Instructores { get; set; }
    public DbSet<Clase> Clases { get; set; }
    public DbSet<Inscripcion> Inscripciones { get; set; }
    public DbSet<Pago> Pagos { get; set; }
    public DbSet<Ritmo> Ritmos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Estudiante>().HasData(
            new Estudiante { Id = 1, Nombre = "Juan", Apellido = "Pérez", FechaNacimiento = new DateTime(1995, 5, 23), Email = "juan.perez@example.com", Telefono = "123456789" },
            new Estudiante { Id = 2, Nombre = "Ana", Apellido = "Gómez", FechaNacimiento = new DateTime(1998, 8, 15), Email = "ana.gomez@example.com", Telefono = "987654321" }
        );

        modelBuilder.Entity<Instructor>().HasData(
            new Instructor { Id = 1, Nombre = "Carlos", Apellido = "López", Especialidad = "Salsa", Email = "carlos.lopez@example.com", Telefono = "555123456" },
            new Instructor { Id = 2, Nombre = "María", Apellido = "Rodríguez", Especialidad = "Bachata", Email = "maria.rodriguez@example.com", Telefono = "555654321" }
        );

        modelBuilder.Entity<Ritmo>().HasData(
            new Ritmo { Id = 1, Nombre = "Salsa", Descripcion = "Un ritmo latino popular" },
            new Ritmo { Id = 2, Nombre = "Bachata", Descripcion = "Un ritmo romántico y sensual" }
        );

        modelBuilder.Entity<Clase>().HasData(
            new Clase { Id = 1, Nombre = "Clase de Salsa", Descripcion = "Aprende los pasos básicos de salsa", InstructorId = 1, Horario = "Lunes y Miércoles 18:00-19:00", RitmoId = 1 },
            new Clase { Id = 2, Nombre = "Clase de Bachata", Descripcion = "Aprende los pasos básicos de bachata", InstructorId = 2, Horario = "Martes y Jueves 19:00-20:00", RitmoId = 2 }
        );

        modelBuilder.Entity<Inscripcion>().HasData(
            new Inscripcion { Id = 1, EstudianteId = 1, ClaseId = 1, FechaInscripcion = DateTime.Now },
            new Inscripcion { Id = 2, EstudianteId = 2, ClaseId = 2, FechaInscripcion = DateTime.Now }
        );

        modelBuilder.Entity<Pago>().HasData(
            new Pago { Id = 1, EstudianteId = 1, Monto = 50.00m, FechaPago = DateTime.Now, MetodoPago = "Tarjeta de Crédito" },
            new Pago { Id = 2, EstudianteId = 2, Monto = 50.00m, FechaPago = DateTime.Now, MetodoPago = "Efectivo" }
        );
    }
}
