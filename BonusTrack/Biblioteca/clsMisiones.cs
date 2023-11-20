using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class clsMisiones
    {
        #region atributos
        private String nombreMision;
        private String descripMision;
        private String creditos;
        #endregion

        #region constructores
        public clsMisiones()
        {
            nombreMision= "";
        }

        public clsMisiones(String mision)
        {
            this.nombreMision =mision;
        }

        public clsMisiones(String descripcionMision, String credito)
        {
            this.descripMision = descripcionMision;
            this.creditos = credito;
        }
        #endregion

        #region propiedades
        public String NombreMision
        {
            get { return nombreMision; }
            set { nombreMision = value; }
        }
        public String Descripcion
        {
            get { return descripMision; }
            set { descripMision = value; }
        }

        public String Creditos
        {
            get { return creditos; }
            set { creditos = value; }
        }
        #endregion
    }
}
