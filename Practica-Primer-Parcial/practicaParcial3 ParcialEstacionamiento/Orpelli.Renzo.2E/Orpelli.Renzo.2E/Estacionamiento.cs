using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Estacionamiento
    {
        //atributos
        private int capacidadEstacionamiento;
        private static Estacionamiento estacionamiento;
        private List<Vehiculo> listadoVehiculos;
        private string nombre;

        //constructores
        private Estacionamiento(string nombre, int capacidad)
        {
            this.listadoVehiculos = new List<Vehiculo>();
            this.nombre = nombre;
            this.capacidadEstacionamiento = capacidad;  
        }

        //propiedades
        /// <summary>
        /// retorna una lista de vehiculos
        /// </summary>
        public List<Vehiculo> ListadoVehiculos
        {
            get { return this.listadoVehiculos; }
        }
        /// <summary>
        /// retorna el nombre del estacionamiento
        /// </summary>
        public string Nombre
        {
            get { return this.nombre;}
        }
        //metodos
        /// <summary>
        /// se encarga de validar si el estacionamiento es null instancia el objeto y si no lo es modifica la capacidad del estacionamiento
        /// <param name="nombre"></param>
        /// <param name="capacidad"></param>
        /// <returns>retorna el objeto estacionamiento</returns>
        public static Estacionamiento GetEstacionamiento(string nombre, int capacidad)
        {
            if(estacionamiento is null)
            {
                Estacionamiento.estacionamiento = new Estacionamiento(nombre, capacidad);
            }
            else if(estacionamiento is not null)
            {
                Estacionamiento.estacionamiento.capacidadEstacionamiento= capacidad;
            }
            return Estacionamiento.estacionamiento;
        }

        public string InformarSalida(Vehiculo v1)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"***{this.nombre}***");
            sb.AppendLine($"VEHICULO: {v1.ToString()}");
            sb.AppendLine($"HORA DE SALIDA: {v1.HoraEgreso}");
            sb.AppendLine($"CARGO POR ESTACIONAMIENTO: ${v1.CostoEstadia.ToString("00.0")}");
            return sb.ToString();

        }

        //sobrecargas
        public static bool operator ==(Estacionamiento e1, Vehiculo v1)
        {
            foreach(Vehiculo vehiculoIgual in e1.listadoVehiculos)
            {
                if(vehiculoIgual == v1)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Estacionamiento e1, Vehiculo v1)
        {
            return !(e1 == v1);
        }


        // operadores
        /// <summary>
        /// se encarca de ver si hay lugar en el estacionamiento y si el vehiculo No esta en el y si estas condiciones se cumplen lo agrega, caso contrario devuelve false
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="v1"></param>
        /// <returns>retorna true si la operacion pudo ser realizada o false de lo contrario</returns>
        public static bool operator +(Estacionamiento e1, Vehiculo v1)
        {
            if(estacionamiento.capacidadEstacionamiento > estacionamiento.ListadoVehiculos.Count  && e1 != v1)
            {
                estacionamiento.listadoVehiculos.Add(v1);
                return true;
            }
            return false;
        }
        /// <summary>
        /// se fija si un vehiculo se encuentra en el estacionamiento y si se cumple esta condicion lo remueve y le asigna la hora de egrese de este vehiculo
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="v1"></param>
        /// <returns>retorna true si la operacion pudo ser realizada o false de lo contrario</returns>
        public static bool operator -(Estacionamiento e1, Vehiculo v1)
        {
            if(e1 == v1)
            {
                v1.HoraEgreso = DateTime.UtcNow.ToLocalTime();
                e1.listadoVehiculos.Remove(v1);
                return true;
            }
            return false;
        }



    }
}
