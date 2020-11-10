using InstitutoCore3._0.Models;
using System.Collections.Generic;

namespace InstitutoCore3._0.Data.Repositories
{
    public interface IAsignaturaRepositorio
    {
        IEnumerable<Asignatura> Obtener();
    }
}