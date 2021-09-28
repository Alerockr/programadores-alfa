using Microsoft.AspNetCore.Mvc;
using ProyectoWEBCOVID.Data;
using ProyectoWEBCOVID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoWEBCOVID.Controllers
{
    public class PersonasControler : Controller
    {

        private readonly ApplicationDbContext _context;

        public PersonasControler(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Persona> listPersonas = _context.Persona;
            return View();
        }
    }
}
