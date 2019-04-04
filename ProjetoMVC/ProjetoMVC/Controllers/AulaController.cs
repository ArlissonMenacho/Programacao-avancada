using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Models;

namespace ProjetoMVC.Controllers
{
    public class AulaController : Controller
    {
        [HttpGet]
        public IActionResult Matricular()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Matricular(Matricular matricular)
        {
            return View();
        }
        public IActionResult novo()
        {
            return View(); 
        }
    }
}