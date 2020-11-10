using InstitutoCore3._0.Models;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstitutoCore3._0.Data.Repositories
{
    public class AsignaturaRepositorio : IAsignaturaRepositorio
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Asignatura> _dbSet;

        public AsignaturaRepositorio(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<Asignatura>();
        }

        public IEnumerable<Asignatura> Obtener()
        {
            return _dbSet.ToList();
        }

        //public List<Asignatura> ObtenerTodos()
        //{
           
        //}
    }
}
