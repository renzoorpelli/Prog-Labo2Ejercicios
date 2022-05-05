using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Automovil : Vehiculo
    {
        private string marca;
        private static double valorHora; // al ser un constructor static el atributo tambien tiene quye serlo

        //CONSTRUCTORES
        static Automovil ()
        {
            valorHora = 120;
        }

        public Automovil (string patente, DateTime horaIngreso, string marca) :base(patente, horaIngreso)
        {
            this.marca = marca;
        }

        //PROPIEDADES
        /// <summary>
        /// retonar el valor de la hora del vehiculo
        /// </summary>
        public  static double ValorHora
        {
            set 
            { 
                if(value > 0)
                {
                    Automovil.valorHora = value; 

                }
            }
        }
        /// <summary>
        /// devuelve el total de horas del vehiculo
        /// </summary>
        public override double CostoEstadia
        {
            get
            {
               return this.CargoEstacionamiento();
            }
        }
        /// <summary>
        /// devuelve la marca del vehiculo
        /// </summary>
        public override string Descripcion
        {
            get
            {
                return this.marca;
            }
        }
        // METODOS
        /// <summary>
        /// retorna el importe a pagar segun la cantidad de horas por el valor
        /// </summary>
        /// <returns></returns>
        protected override double CargoEstacionamiento()
        {
            return base.CargoEstacionamiento() * valorHora;
        }
        /// <summary>
        /// funcion se encarga de mostrar los datos del automovil
        /// </summary>
        /// <returns>string con los datos del automovil</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"****AUTOMOVIL*****");
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"MARCA: {this.Descripcion}");
            return sb.ToString();

        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
