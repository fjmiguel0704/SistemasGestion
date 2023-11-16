namespace Ejercicio1y2Ud7.Models.Entidades
{
    public class clsDepartamento
    {
        #region atributos
        private int id;
        private string nombre;
        #endregion

        #region constructor
        public clsDepartamento(int id, string nombre) { 
            this.id = id;
            this.nombre = nombre;
        }
        #endregion

        #region propiedades
        public int Id 
        {
            get { return id; }
            set { id = value; }
        }
        #endregion
    }
}
