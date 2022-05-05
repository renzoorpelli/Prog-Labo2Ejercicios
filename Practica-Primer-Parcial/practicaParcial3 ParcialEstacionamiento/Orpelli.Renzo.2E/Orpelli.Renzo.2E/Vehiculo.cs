using System;
using System.Text;


namespace Entidades
{
    public abstract class Vehiculo
    {
        private DateTime horaEgreso;
        private DateTime horaIngreso;
        private string patente;
        public enum EVehiculo { Automovil, Moto }

        public Vehiculo (string patente, DateTime horaIngreso)
        {
            this.Patente = patente;
            this.horaIngreso = horaIngreso;
        }
        /// <summary>
        /// propiedad encargada de de obterner y setear la hora de egreso de un vehiculo validando que esta sea mayor a la de ingreso
        /// </summary>
        public DateTime HoraEgreso
        {
            get { return this.horaEgreso; }
            set 
            {
                if(value > this.horaIngreso)
                {
                    this.horaEgreso = value;
                }
            }
        }

        /// <summary>
        /// propiedad encargada de obtener la hora de ingreso de un vehiculo
        /// </summary>
        public DateTime HoraIngreso
        {
            get { return this.horaIngreso; }
        }

        public string Patente
        {
            get { return this.patente; }
            set 
            {
                if(ValidarPatente(value))
                {
                    this.patente = value; 
                }
                else
                {
                    value = "aaaaaaa";
                    this.patente = value;
                }
            }
        }
        // al estar en cursiva (en el enunciado, diagrama de clases) significa que estramos tratando con clases abstractas
        public abstract double CostoEstadia { get;}
        public abstract string Descripcion { get;}

        /// <summary>
        /// valida que el length de la cadena este entre 6 o 7 caracteres
        /// </summary>
        /// <param name="patente"></param>
        /// <returns></returns>
        private bool ValidarPatente(string patente)
        {
            if(patente.Length >= 7 && patente.Length < 8 && !string.IsNullOrEmpty(patente))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// calcula el total de las horas de un vehiculo en el estacionamiento
        /// </summary>
        /// <returns>reotrna el total de las horas de un vehiculo en el estacinamiento o retorna 0 si las horas ingresadas fueron invalidas</returns>
        protected virtual double CargoEstacionamiento()
        {
            double totalHoras = 0;
            if(this.horaEgreso > this.horaIngreso)
            {
                totalHoras = (this.horaEgreso - this.horaIngreso).TotalHours;
            }
            return totalHoras;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($" Patente: {this.patente}\n Hora Ingreso: {this.HoraIngreso}");
            return sb.ToString();
        }
        /// <summary>
        /// se encarga de verificar si dos vehiculos son iguales verificando las patentes
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>retorna true si son iguales o false si no</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.patente == v2.patente;
        }
        /// <summary>
        /// verifica que dos vehiculos son distintos basandose en el criterio de patente sobrecargado en el operador ==
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>retorna true si son distintos</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1==v2);
        }



    }
}
