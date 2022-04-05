using System;

namespace Billetes
{
    public class Pesos
    {
        double cantidad;
        static double cotzRespectoDolar;

        // conmstructores
        Pesos()
        {
            cotzRespectoDolar = 1 / 102.65;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion) :this(cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }

        // explicits cotizaciones por cantidad
        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.cantidad / cotzRespectoDolar);
        }

        public static explicit operator Euro(Pesos p)
        {
            return ((Euro)(Dolar)p);
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
