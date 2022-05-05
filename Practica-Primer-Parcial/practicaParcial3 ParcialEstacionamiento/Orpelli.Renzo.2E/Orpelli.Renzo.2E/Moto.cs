using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Moto : Vehiculo
    {
        //enum
        public enum ETipo { Ciclomotor, Scooter, Sport}
        //atributos
        private ETipo tipoMoto;
        private static double valorHora;

        //constructores
        static Moto()
        {
            valorHora = 100;
        }

        public Moto(string patente, DateTime horaIngreso, ETipo tipoMoto) : base(patente, horaIngreso)
        {
            this.tipoMoto = tipoMoto;
        }


        //Propiedades
        /// <summary>
        /// retonar el valor de la hora de la moto
        /// </summary>
        public static double ValorHora
        {
            set
            {
                if (value > 0)
                {
                    Moto.valorHora = value;

                }
            }
        }

        /// <summary>
        /// devuelve el total de horas de la moto
        /// </summary>
        public override double CostoEstadia
        {
            get
            {
                return this.CargoEstacionamiento();
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
        /// devuelve la marca de la moto
        /// </summary>
        public override string Descripcion
        {
            get
            {
                return this.tipoMoto.ToString();
            }
        }

        /// <summary>
        /// funcion se encarga de mostrar los datos de la moto
        /// </summary>
        /// <returns>string con los datos de la moto</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"****Moto*****");
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"TIPO: {this.tipoMoto}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
