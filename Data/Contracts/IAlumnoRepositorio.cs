﻿using InstitutoCore3._0.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InstitutoCore3._0.Data.Repositories
{
    public interface IAlumnoRepositorio
    {
        IEnumerable<Alumno> Obtener();
    }
}