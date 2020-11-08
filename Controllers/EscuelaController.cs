using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstitutoCore3._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace InstitutoCore3._0.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
