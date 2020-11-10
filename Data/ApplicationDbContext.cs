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

            var alumnos = new List<Alumno>() {
                new Alumno { Nombre = "Juan Perez" },
                new Alumno { Nombre = "Roberto Sanchez" },
                new Alumno { Nombre = "Maria Lopez" },
                new Alumno { Nombre = "Sofia Gonzalez" }
            }; 

            builder.Entity<Alumno>().HasData(alumnos);

            //var asignatura = new Asignatura { Nombre = "Matemáticas" };

            var listaAsignaturas = new List<Asignatura>(){
                            new Asignatura{Nombre="Matemáticas", imagen = "/img/image.jpg", descripcion="daasdasdasdasda"} ,
                            new Asignatura{Nombre="Programacion", imagen = "/img/image.jpg", descripcion="daasdasdasdasda"},
                            new Asignatura{Nombre="Ingles", imagen = "/img/image.jpg", descripcion="daasdasdasdasda"},
                            new Asignatura{Nombre="Fisica", imagen = "/img/image.jpg", descripcion="daasdasdasdasda"}
                };

            builder.Entity<Asignatura>().HasData(listaAsignaturas.ToArray());
        }
    }
}
