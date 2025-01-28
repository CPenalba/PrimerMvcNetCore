using Microsoft.AspNetCore.Mvc;
using PrimerMvcNetCore.Models;
using System.Globalization;

namespace PrimerMvcNetCore.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult VistaControllerPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VistaControllerPost(Persona p, string aficiones)
        {
            ViewData["DATA"] = "Nombre " + p.Nombre + ", Email " + p.Email + ", Edad " + p.Edad
                + ", Aficiones " + aficiones;
            return View();
        }

        //VAMOS A RECIBIR DOS PARAMETROS
        public IActionResult VistaControllerGet(string saludo, System.Nullable<int> year)
        {
            if(year != null)
            {
                ViewData["DATA"] = "Hola " + saludo + " en el año " + year;
            }
            else
            {
                ViewData["DATA"] = "Aqui no tenemos tiempo ya..";
            }
            
            return View();
        }
        
        public IActionResult ControladorVista()
        {
            //VAMOS A ENVIAR INFORMACION SIMPLE A NUESTRA VISTA
            ViewData["NOMBRE"] = "Alumno";
            ViewData["EDAD"] = 24;
            ViewBag.DiaSemana = "Lunes";
            return View();
        }

        public IActionResult ControladorVistaModel()
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Email = "alumno@email.com";
            persona.Edad = 27;
            return View(persona);
        }
    }
}
