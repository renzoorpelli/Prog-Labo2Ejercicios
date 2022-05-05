using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AppMusical : Aplicacion
    {
        private List<string> listaCanciones;
        //propiedades

        /// <summary>
        /// cada cancion ocupa 2mb entonces multiplico la cantidad total de canciones por 2 y esta cuenta me daria
        /// el resultado de cuanto ocuapan las canciones, entonces se lo sumo al tamanio de la aplicacion
        /// </summary>
        protected override int Tamanio
        {
            get
            {
                int tamanio = listaCanciones.Count * 2;
                return tamanioMB + tamanio;
            }
        }

        //Constructores
        /// <summary>
        /// construyo la app musical trayendo la sobrecarga del constructor e instanciandole la lista como parametro
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="sistemaOperativo"></param>
        /// <param name="tamanioInicial"></param>
        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial)
            : this(nombre, sistemaOperativo, tamanioInicial, new List<string>())
        {
        }
        /// <summary>
        /// construyo la app musical pasandole la lista como nuevo parametro y trayendo del constructor base los demas
        /// parametros, verifico si la lista es null y si lo es instancio una nueva lista
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="sistemaOperativo"></param>
        /// <param name="tamanioInicial"></param>
        /// <param name="listaCanciones"></param>
        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial, List<string> listaCanciones)
            : base(nombre, sistemaOperativo, tamanioInicial)
        {
            if (listaCanciones is null)
            {
                this.listaCanciones = new List<string>();
            }
            else
            {
                this.listaCanciones = listaCanciones;
            }
        }

        // metodos
        /// <summary>
        /// obtengo la informacion de la app de la clase base y le agrego la lista de canciones 
        /// </summary>
        /// <returns></returns>
        public override string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ObtenerInformacionApp());
            sb.AppendLine("LISTA DE CANCIONES:");
            foreach(string cancion in listaCanciones)
            {
                sb.AppendLine(cancion);
            }
            return sb.ToString();
        }
    }
}
