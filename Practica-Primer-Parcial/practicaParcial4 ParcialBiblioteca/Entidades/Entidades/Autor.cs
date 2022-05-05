using System;

namespace Entidades
{
    public class Autor
    {
        private string apellido;
        private string nombre;

        /// <summary>
        /// construye un autor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Autor(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        /// <summary>
        /// se encarga de verificar si los autores son iguales por nombr y apellido
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public static bool operator ==(Autor a1, Autor a2)
        {
            return a1.nombre == a2.nombre && a1.apellido==a2.apellido;
        }
        public static bool operator !=(Autor a1, Autor a2)
        {
            return !(a1 == a2);
        }

        /// <summary>
        /// retorna el nombre y el apellido del autor que recibe como parametro
        /// </summary>
        /// <param name="a"></param>
        public static  implicit operator string(Autor a)
        {
            return a.nombre + " " + a.apellido; 
        }

       
     }
}
