using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class HomeController : Controller
    {
        public String Index()
        {
            return "Fernando";
        }
        public String Apellidos()
        {
            return "Miguel Gómez";
        }

        public IActionResult Saludo()
        {
            return View();
        }

    }
}
