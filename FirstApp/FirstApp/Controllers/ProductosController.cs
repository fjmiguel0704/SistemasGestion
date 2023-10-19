using Microsoft.AspNetCore.Mvc;

namespace Ejercicio1y2.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult ListadoProductos()
        {
            return View();
        }
    }
}
