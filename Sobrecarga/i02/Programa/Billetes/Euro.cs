using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        double cantidad;
        static double cotzRespectoDolar;

        //constructores
        Euro()
        {
            cotzRespectoDolar =  1 / 1.17;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad,double  cotizacion) :this(cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }

        // explicits cotizaciones por cantidad
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / cotzRespectoDolar);
        }

        public static explicit operator Pesos(Euro e)
        {
            return ((Pesos)(Dolar)e);
        }

        // implicits
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        // getters
        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        public double GetCantidad()
        {
            return cantidad;
        }


    }
}
