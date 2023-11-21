using Biblioteca;
using BonusTrack.DAL;

namespace BonusTrack.Models.VM
{
    public class ViewModel : clsMisiones
    {
        public List<clsMisiones> listadoMisiones = ListadoMisiones.listarMisiones();


        public ViewModel()
        {

        }

        public ViewModel(String nombreMision, String descr, String creditos) : base(nombreMision, descr, creditos)
        {

        }
    }
}
