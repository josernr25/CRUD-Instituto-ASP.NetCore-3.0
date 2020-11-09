using System;
using System.Collections.Generic;
using System.Text;
using InstitutoCore3._0.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InstitutoCore3._0.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        // Aca se definen los DBSets
        // public DbSet<Entidad> NombreDeEntidadEnPlural {get; set;}

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Evaluacion> Evaluaciones { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var alumno = new Alumno { Nombre = "Juan Perez" };

            builder.Entity<Alumno>().HasData(alumno);
        }
    }
}
