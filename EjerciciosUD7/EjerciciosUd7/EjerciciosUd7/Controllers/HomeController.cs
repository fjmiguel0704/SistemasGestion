using Ejercicio1Ud7.Models.Entidades;
using EjerciciosUd7.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjerciciosUd7.Controllers
{
    public class HomeController : Controller
    {
        Persona per = new Persona();
        DateTime horaActual = DateTime.Now;
        public IActionResult Index()
        {
            ViewBag.HoraActual = horaActual.ToLongTimeString();

            if (horaActual.Hour >= 7 && horaActual.Hour < 12) 
            {
                ViewData["Saludo"] = "Buenos días";
            }
            else if (horaActual.Hour >= 12 && horaActual.Hour < 9) {
                ViewData["Saludo"] = "Buenas tardes";
            } else {
                ViewData["Saludo"] = "Buenas noches";
            }

            per.Nombre = "Fernando José";
            per.Apellidos = "Miguel Gómez";

            return View(per);

        }

    }
}