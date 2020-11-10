using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstitutoCore3._0.Data.Repositories;
using InstitutoCore3._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace InstitutoCore3._0.Controllers
{
    public class AlumnoController : Controller
    {
        private readonly IAlumnoRepositorio _alumnoRepositorio;

        public AlumnoController(IAlumnoRepositorio alumnoRepositorio)
        {
            _alumnoRepositorio = alumnoRepositorio;
        }

        public IActionResult Index()
        {
            var alumnos = _alumnoRepositorio.Obtener();

            return View(alumnos);
        }
    }
}
