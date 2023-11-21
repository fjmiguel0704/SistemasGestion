using Biblioteca;
using BonusTrack.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BonusTrack.Models.VM;

namespace BonusTrack.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewModel viewModel = new ViewModel();  

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Index(string nombreMision)
        {
            clsMisiones misionActual = ListadoMisiones.listarMisiones().Find(x => x.NombreMision == nombreMision);

            ViewModel listadoMisionesActuales = new ViewModel(
                misionActual.NombreMision,
                misionActual.Descripcion,
                misionActual.Creditos
                );
            return View(listadoMisionesActuales);
        }
    }
}