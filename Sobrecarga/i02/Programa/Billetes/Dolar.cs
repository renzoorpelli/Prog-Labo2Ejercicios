using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        double cantidad;
        static double cotzRespectoDolar;
        //constructores
        Dolar ()
        {
            cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        // explicit cotizaciones x cantidad
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(Euro.GetCotizacion()* d.cantidad);
        }

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(Pesos.GetCotizacion() * d.cantidad);
        }

        //getters
        public static double GetCotizacion ()
        {
            return cotzRespectoDolar;
        }

        public double GetCantidad ()
        {
            return cantidad;
        }
    }
}
