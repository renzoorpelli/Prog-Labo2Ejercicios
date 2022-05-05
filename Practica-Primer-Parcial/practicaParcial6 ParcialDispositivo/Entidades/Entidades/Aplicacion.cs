using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public enum SistemaOperativo { ANDROID, IOS}
    public abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMB;

        //CONSTRUCTORES
        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMB)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMB = tamanioMB;
        }

        //PROPIEDADES
        /// <summary>
        /// retorna el nombre del sistema operativco
        /// </summary>
        public SistemaOperativo SistemaOperativo
        {
            get { return sistemaOperativo; }
        }

        /// <summary>
        /// propiedad abstracta que sera base en las otras clases
        /// </summary>
        protected abstract int Tamanio { get; }

        /// <summary>
        /// sobrecarga implicita de aplicacion, se encarga de recorrer la lista de aplicaciones buscando saber cual es 
        /// la aplicacion mas pesada que tiene instalada
        /// </summary>
        /// <param name="listaApp"></param>

        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            int tamanioMax = int.MinValue;
            Aplicacion aplicacionPesada = null;
            foreach (Aplicacion app in listaApp)
            {
                if (app.tamanioMB > tamanioMax)
                {
                    tamanioMax = app.tamanioMB;
                    aplicacionPesada = app;
                }
            }
            return aplicacionPesada;
        }
        /// <summary>
        /// Se encarga de obterner toda la informacion de la app, es una funcion virtual ya que va a ser sobrecargada en 
        /// sus clases hijas que le agregaran elementos
        /// </summary>
        /// <returns></returns>
        public virtual string ObtenerInformacionApp()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"NOMBRE: {nombre}");
            stringBuilder.AppendLine($"SISTEMA OPERATIVO: {SistemaOperativo}");
            stringBuilder.AppendLine($"TAMAÑO: {Tamanio}");

            return stringBuilder.ToString();
        }

        /// <summary>
        /// sobrecarga del metodo toString
        /// </summary>
        /// <returns>devuelve el nombre de la aplicacion</returns>
        public override string ToString()
        {
            return this.nombre;
        }
        /// <summary>
        /// recorre la lista verificando si la app ya se encuentra en esta utilizado como criterio el nombre
        /// </summary>
        /// <param name="listaApp"></param>
        /// <param name="app"></param>
        /// <returns></returns>
        public static bool operator ==(List<Aplicacion> listaApp, Aplicacion app)
        {
            if(listaApp is not null ||  app is not null)
            {
                foreach (Aplicacion appFound in listaApp)
                {
                    if(appFound.nombre == app.nombre)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }
        /// <summary>
        /// recorre la lista y si la app no se encuentra en ella la agrega
        /// </summary>
        /// <param name="listaApp"></param>
        /// <param name="app"></param>
        /// <returns></returns>
        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            if(listaApp != app)
            {
                listaApp.Add(app);
                return true;
            }
            return false;
        }


    }
}
