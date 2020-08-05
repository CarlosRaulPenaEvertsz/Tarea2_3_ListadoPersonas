using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tarea2_3_ListadoPersonas.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var personas = new List<Models.Persona>
            {
                    new Models.Persona { Nombres = "José Eleutelio", Apellidos = "Pérez Moreno", Sexo = "M", Edad = 21, Ocupacion="Estudiante" },
                    new Models.Persona { Nombres = "Isis Yaniris", Apellidos = "Mendoza Zapata", Sexo = "F", Edad = 27, Ocupacion="Pediatra" },
                    new Models.Persona { Nombres = "Zoilo", Apellidos = "Moreta Martínez", Sexo = "M", Edad = 35, Ocupacion="Ingeniero Civil" },
                    new Models.Persona { Nombres = "Epifaneo Escolástico", Apellidos = "Rodríguez Cuello", Sexo = "M", Edad = 31, Ocupacion="Abogado" },
                    new Models.Persona { Nombres = "Iris María", Apellidos = "Perdomo Castro", Sexo = "F", Edad = 41, Ocupacion="Empresaria" },
                    new Models.Persona { Nombres = "Ana Patricia", Apellidos = "Fernandez Campusano", Sexo = "F", Edad = 25, Ocupacion="Secretaria" }
            };

            return View(personas);
        }
    }
}