using Microsoft.AspNetCore.Mvc;
using PrimerMvcNetCore.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public IActionResult ConjeturaCollatz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConjeturaCollatz(int numero)
        {
            //DEBEMOS DEVOLVER UN OBJETO COMPLEJO CON 
            //UNA LISTA DE NUMEROS
            List<int> numeros = new List<int>();
            while (numero != 1)
            {
                if (numero % 2 == 0)
                {
                    numero = numero / 2;
                }
                else
                {
                    numero = numero * 3 + 1;
                }
                numeros.Add(numero);
            }
            //DEVOLVEMOS EL MODEL A LA VISTA
            return View(numeros);

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

        public IActionResult TablaMultiplicarSimple()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicarSimple(int numero)
        {
            List<int> resultados = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                int operacion = numero * i;
                resultados.Add(operacion);
            }
            return View(resultados);
        }

        public IActionResult TablaMultiplicarModel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicarModel(int numero)
        {
            List<FilaTablaMultiplicar> filas = new List<FilaTablaMultiplicar>();
            for (int i = 1; i <= 10; i++)
            {
                FilaTablaMultiplicar fila = new FilaTablaMultiplicar();
                fila.Operacion = numero + " * " + i;
                fila.Resultado = numero * i;
                filas.Add(fila);
            }
            return View(filas);
        }
    }
}
