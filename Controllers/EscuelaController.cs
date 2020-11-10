using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstitutoCore3._0.Data.Repositories;
using InstitutoCore3._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace InstitutoCore3._0.Controllers
{
    public class EscuelaController : Controller
    {
        private readonly IAsignaturaRepositorio _asignaturaRepositorio;

        public EscuelaController(IAsignaturaRepositorio asignaturaRepositorio)
        {
            _asignaturaRepositorio = asignaturaRepositorio;
        }

        public IActionResult Index()
        {
            //var escuela = new Escuela();
            //escuela.Nombre = "Maria Auxiliadora";
            //escuela.AnioDeCreacion = 1978;
            //escuela.Direccion = "Av. Libertad 2283";
            //escuela.Pais = "Argentina";
            //escuela.Ciudad = "Corrientes";
            //escuela.TipoEscuela = TiposEscuela.Secundaria;
            var asignatura = _asignaturaRepositorio.Obtener();

            return View(asignatura);
        }
    }
}
