using Biblioteca;
namespace BonusTrack.Models
{
    static public class ListadoMisiones
    {
        static public List<clsMisiones> listarMisiones()
        {
            List<clsMisiones> listadoCompletoMisiones = new List<clsMisiones>()
            {
                new clsMisiones("Rescate de Baby Yoda"),
                new clsMisiones("Recuperar armadura Beskar"),
                new clsMisiones("Planeta Sorgon"),
                new clsMisiones("Renacuajos")
            };

            return listadoCompletoMisiones;
        }
    }
}
