using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstitutoCore3._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace InstitutoCore3._0.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var listaAsignaturas = new List<Asignatura>(){
                            new Asignatura{Nombre="Matemáticas"} ,
                            new Asignatura{Nombre="Programacion"},
                            new Asignatura{Nombre="Ingles"},
                            new Asignatura{Nombre="Fisica"}
                };

            ViewBag.Fecha = DateTime.Now;

            return View(listaAsignaturas);
        }
    }
}
