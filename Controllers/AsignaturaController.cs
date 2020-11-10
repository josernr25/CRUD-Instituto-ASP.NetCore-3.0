using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstitutoCore3._0.Data.Repositories;
using InstitutoCore3._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace InstitutoCore3._0.Controllers
{
    public class AsignaturaController : Controller
    {
        private readonly IAsignaturaRepositorio _asignaturaRepositorio;

        public AsignaturaController(IAsignaturaRepositorio asignaturaRepositorio)
        {
            _asignaturaRepositorio = asignaturaRepositorio;
        }

        public IActionResult Index()
        {
            var asignatura = _asignaturaRepositorio.Obtener();

            ViewBag.Fecha = DateTime.Now;

            return View(asignatura);
        }
    }
}
