using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class clsPersona
    {
        #region atributos
        private int id;
        private String nombre;
        private String apellido;
        private int idDept;
        private DateTime fNac;
        private String foto;
        private String tlfn;
        private String direccion;
        #endregion

        #region constructores
        public clsPersona()
        {
            nombre= "";
        }

        public clsPersona(int id, String nombre, String apellido, int departamento, DateTime fechaNacimiento, String foto, String telefono, String direccion)
        {
            this.id = id;
            this.nombre =nombre;
            this.apellido = apellido;
            this.idDept = departamento;
            this.fNac = fechaNacimiento;
            this.foto = foto;
            this.tlfn = telefono;
            this.direccion = direccion;
        }
        #endregion

        #region propiedades
        public int Id
        {
            get { return id; }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int Departamento
        {
            get { return idDept; }
            set { idDept = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fNac; }
            set { fNac = value; }
        }

        public String Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        public String Telefono
        {
            get { return tlfn; }
            set { tlfn = value; }
        }

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        #endregion
    }
}
