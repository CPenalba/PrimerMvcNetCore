using Microsoft.AspNetCore.Mvc;

namespace PrimerMvcNetCore.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SumarNumerosGet(int n1,int n2)
        {
            int suma = n1 + n2;
            ViewData["MENSAJE"] = "La suma de " + n1 + " + " + n2 + " = " + suma;
            return View();
        }

        public IActionResult SumarNumerosPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SumarNumerosPost(int n1, int n2)
        {
            int suma = n1 + n2;
            ViewData["MENSAJE"] = "La suma de " + n1 + " + " + n2 + " = " + suma;
            return View();
        }
    }
}
