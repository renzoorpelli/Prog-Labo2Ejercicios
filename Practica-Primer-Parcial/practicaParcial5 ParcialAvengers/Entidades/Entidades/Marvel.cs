using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Marvel
    {
        private static List<Personaje> listaDePersonajes;
        /// <summary>
        /// constructor encargado de instanciar la lista de personajes
        /// </summary>
        static Marvel()
        {
            listaDePersonajes = new List<Personaje>();
        }

        // propiedades
        /// <summary>
        /// setter encargado de verificar que el personaje no este en la lista utilizando la sobrecarga
        /// del operador != y si esta devuelve que no esta en la lista agrega el personaje a la lista
        /// con la sobrecarga del operador +
        /// </summary>
        public static Personaje Personaje
        {
            set 
            {
                if(listaDePersonajes != (Personaje)value)
                {
                    listaDePersonajes += value;
                }
            }
        }
        //metodo 
        /// <summary>
        /// muestra la informacion de cada personaje pero antes verifica si es avenger o enemigo para anadirle un titulo
        /// </summary>
        /// <returns></returns>
        public static string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Personaje item in listaDePersonajes)
            {
                if(item is Avenger)
                {
                    sb.AppendLine("****** AVENGER ******");
                    sb.AppendLine(item.ToString());
                }
                else
                {
                    sb.AppendLine("****** ENEMIGO ******");
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString();
        }
    }
}
