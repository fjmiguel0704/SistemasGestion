using Biblioteca;

namespace BonusTrack.DAL
{
    static public class ListadoMisiones
    {
        static public List<clsMisiones> listarMisiones()
        {
            List<clsMisiones> listadoCompletoMisiones = new List<clsMisiones>()
            {
                new clsMisiones("Rescate de Baby Yoda", "Debes hacerte con Grogu y llevárselo a Luke SkyWalker para su entrenamiento.", "Recompensa: 5000 créditos"),
                new clsMisiones("Recuperar armadura Beskar","Tu armadura de Beskar ha sido robada. Debes encontrarla.", "Recompensa: 2000 créditos"),
                new clsMisiones("Planeta Sorgon","Debes llevar a un niño de vuelta a su planeta natal “Sorgon”.", "Recompensa: 500 créditos."),
                new clsMisiones("Renacuajos","Debes llevar a una Dama Rana y sus huevos de Tatooine a la luna del estuario Trask, donde su esposo fertilizará los huevos.", "Recompensa: 500 créditos")
            };

            return listadoCompletoMisiones;
        }
    }
}
