using Ejercicio1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.Data.SqlClient;
namespace Ejercicio1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            SqlConnection miConexion = new SqlConnection();
            ViewBag.EstadoConexion = "No se ha podido conectar";

            try {
                miConexion.ConnectionString = "server=107-16\\SQLEXPRESS;database=persona;uid=usuario;pwd=123;trustServerCertificate=true";
                miConexion.Open();
                ViewBag.EstadoConexion = $"Conectado: {miConexion.State}";
            } catch (Exception ex)
            {
                ViewBag.EstadoConexion = $"Error al conectar: {ex.Message}";
            }
            return View();
        }
    }
}