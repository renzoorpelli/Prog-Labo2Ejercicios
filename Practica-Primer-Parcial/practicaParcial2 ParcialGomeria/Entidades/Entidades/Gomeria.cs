using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public  class Gomeria
    {
        protected  List<Vehiculo> listaVehiculo = new List<Vehiculo>();

        public  List<Vehiculo> ListaVehiculos
        {
            get { return listaVehiculo; }
            set { listaVehiculo = value; }
        }

        public  Gomeria()
        {
            listaVehiculo = new List<Vehiculo>();
        }

        public static Gomeria operator +(Gomeria gomeria, Vehiculo v1)
        {
            if (gomeria is not null)
            {
                gomeria.ListaVehiculos.Add(v1);
            }
            return gomeria;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Vehiculo vehiculo in listaVehiculo)
            {
                sb.AppendLine(vehiculo.ToString());
            }
            return sb.ToString();
        }
    }
}
