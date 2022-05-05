using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AppJuegos : Aplicacion
    {

        //propiedades
        /// <summary>
        /// obtengo el tamanio de la app
        /// </summary>
        protected override int Tamanio
        {
            get
            {
                return tamanioMB;
            }
        }

        //Constructores
        /// <summary>
        /// construyo una app de juegos y esta ocupa todos los parametros de la clase base 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="sistemaOperativo"></param>
        /// <param name="tamanio"></param>
        public AppJuegos(string nombre, SistemaOperativo sistemaOperativo, int tamanio):base(nombre, sistemaOperativo, tamanio)
        {

        }

        


    }
}
