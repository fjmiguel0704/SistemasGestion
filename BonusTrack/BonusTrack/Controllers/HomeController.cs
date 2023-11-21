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
            return View();
        }

        [HttpPost]
        public IActionResult Index(clsMisiones detallesMisiones)
        {
            return View("Index");
        }
    }
}