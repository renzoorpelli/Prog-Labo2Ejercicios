using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;


        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion; 
        }

        public string Nombre
        {
            get { return nombre; }  
        }

        public string Ficha()
        {
            return $"[EQUIPO {this.Nombre}] fundado el [FECHA: {this.fechaCreacion}]";
        }
        /// <summary>
        /// dos equipos seran iguales si comparten el nombre y la fecha de creacion
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }




    }
}
