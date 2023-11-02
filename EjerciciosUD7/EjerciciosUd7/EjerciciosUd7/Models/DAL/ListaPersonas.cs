using Ejercicio1Ud7.Models.Entidades;

namespace Ejercicio1y2Ud7.Models.DAL
{
    public static class ListaPersonas
    {
        /// <summary>
        ///Funcion que devuelve un listado de personas completo 
        ///Pre ninguna
        ///Post: ninguna
        /// </summary>
        /// <returns>listado personas</returns>
        public static List<Persona> listadoCompletoPersonas (){
            List<Persona> listadoPersonas = new List<Persona>() { 
                new Persona("Fernando", "Miguel"),
                new Persona("Juanma", "Sanchez"),
                new Persona("Yeray", "Jimenez")
            };

            return listadoPersonas;
            
        }
    }
}
