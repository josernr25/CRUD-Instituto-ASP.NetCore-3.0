using InstitutoCore3._0.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstitutoCore3._0.Data.Repositories
{
    public class AlumnoRepositorio : IAlumnoRepositorio
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Alumno> _dbSet;

        public AlumnoRepositorio(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<Alumno>();
        }

        public Alumno Obtener()
        {
            
            return _dbSet.FirstOrDefault<Alumno>();
        }

    }
}
