using Biblioteca;
using BonusTrack.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BonusTrack.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<clsMisiones> listaMisiones = ListadoMisiones.listarMisiones();
            return View(listaMisiones);
        }
    }
}