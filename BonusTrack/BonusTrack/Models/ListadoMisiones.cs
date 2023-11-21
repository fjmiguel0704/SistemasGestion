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

        static public List <clsMisiones> listarDetallesMisiones()
        {
            List<clsMisiones> listadoCompletoDetalles = new List<clsMisiones>()
            {
                new clsMisiones("Debes hacerte con Grogu y llevárselo a Luke SkyWalker para su entrenamiento.", "Recompensa: 5000 créditos"),
                new clsMisiones("Tu armadura de Beskar ha sido robada. Debes encontrarla.", "Recompensa: 2000 créditos"),
                new clsMisiones("Debes llevar a un niño de vuelta a su planeta natal “Sorgon”.", "Recompensa: 500 créditos."),
                new clsMisiones("Debes llevar a una Dama Rana y sus huevos de Tatooine a la luna del estuario Trask, donde su esposo fertilizará los huevos.", "Recompensa: 500 créditos"),
            };

            return listadoCompletoDetalles;
        }
    }
}
