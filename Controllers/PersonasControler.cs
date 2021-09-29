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

        //GET INDEX
        public IActionResult Index()
        {
            IEnumerable<Persona> listPersonas = _context.Persona;           
            return View(listPersonas);
        }

        //GET CREAR
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //post create
        public IActionResult Create(Persona persona)
        {
            if (ModelState.IsValid)
            {
                _context.Persona.Add(persona);
                _context.SaveChanges();
                TempData["mensaje"] = "Registro Exitoso";
                return RedirectToAction("Index");
            }
            return View();
        }

        //GET EDITAR
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //Obtener la persona
            var persona = _context.Persona.Find(id);

            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }
        //POST EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Persona persona)
        {
            if (ModelState.IsValid)
            {
                _context.Persona.Update(persona);
                _context.SaveChanges();
                TempData["mensaje"] = "La persona se ha actualizado";
                return RedirectToAction("Index");
            }
            return View();
        }

        //GET DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            //Obtener la persona
            var persona = _context.Persona.Find(id);

            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        //POST DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePersona(int? id)
        {
            //Obtener la persona por id

            var persona = _context.Persona.Find(id);

            if (persona == null)
            {
                return NotFound();
            }

                _context.Persona.Remove(persona);
                _context.SaveChanges();
                TempData["mensaje"] = "La persona se ha Eliminado";
                return RedirectToAction("Index");

        }
    }
}
