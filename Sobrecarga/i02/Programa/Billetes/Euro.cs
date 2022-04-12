using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;
        //constructores
        static Euro()
        {
            cotzRespectoDolar = 1 / 1.17;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }


        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotzRespectoDolar =  cotizacion;
        }

        // getters
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Euro.cotzRespectoDolar;
        }

        //
        public static implicit operator Euro(double euro)
        {
            return new Euro(euro);
        }


        // sobrecargas explicitas para peso y dolar

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / Euro.GetCotizacion());
        }

        public static explicit operator Peso(Euro e)
        {
            return ((Peso)(Dolar)e); // re utilizo conversion explicita
        }

        // sobrecargas para los comparadores y operadores aritmeticos

        public static bool operator ==(Euro e1, Euro e2) // sobrecargo == 
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        // Dolar
        public static bool operator ==(Euro e, Dolar d) // si la cantidad de Euros es igual a la cantidad de dolares convertidos a euros
        {
            return e.GetCantidad() == ((Euro)d).GetCantidad();
        }

        public static bool operator !=(Euro e, Dolar d) // sobrecargo == 
        {
            return !(e == d);
        }

        // Peso

        public static bool operator ==(Euro e, Peso p) // si la cantidad de Euros es igual a la cantidad de pesos convertidos a Euros
        {
            return e.GetCantidad() == ((Euro)p).GetCantidad();
        }

        public static bool operator !=(Euro e, Peso p) // sobrecargo == 
        {
            return !(e == p);
        }

        // Dolar
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() - ((Euro)d).GetCantidad()); // retorna la resta entre las cantidades de Euros y Dolares convertidos a euros
        }

        // Peso
        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad() - ((Euro)p).GetCantidad()); // retorna la resta de euros y pesos convertidos a euros
        }


        // Dolar
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() + ((Euro)d).GetCantidad()); // retorna la SUMA entre las cantidades de euros y dolares convertidos a euros
        }

        // Peso
        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad() + ((Euro)p).GetCantidad()); // retorna la SUMA de euros y pesos convertidos a euros
        }




    }
}
