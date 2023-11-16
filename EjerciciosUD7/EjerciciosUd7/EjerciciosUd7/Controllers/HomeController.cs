using Ejercicio1Ud7.Models.Entidades;
using Ejercicio1y2Ud7.Models.DAL;
using EjerciciosUd7.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjerciciosUd7.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            Persona per = new Persona();
            DateTime fechaYhoraActual = DateTime.Now;

            ViewBag.HoraActual = fechaYhoraActual.ToLongDateString();

            if (fechaYhoraActual.Hour >= 7 && fechaYhoraActual.Hour < 12) 
            {
                ViewData["Saludo"] = "Buenos días";
            }
            else if (fechaYhoraActual.Hour >= 12 && fechaYhoraActual.Hour < 21) {
                ViewData["Saludo"] = "Buenas tardes";
            } else {
                ViewData["Saludo"] = "Buenas noches";
            }

            per.Nombre = "Fernando José";
            per.Apellidos = "Miguel Gómez";

            return View(per);

        }

        public IActionResult listadoPersonas()
        {
            try {
                return View(ListaPersonas.listadoCompletoPersonas());
            } 
            catch (Exception ex) {
                return View("Error");
            }
            
        }

    }
}