using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;
        //constructores
        static Dolar()
        {
            cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }


        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            Dolar.cotzRespectoDolar = cotizacion;
        }

        // getters
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Dolar.cotzRespectoDolar;
        }



        public static implicit operator Dolar(double dolar)
        {
            return new Dolar(dolar);
        }


        // sobrecargas explicitas para euro y peso

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * Euro.GetCotizacion());
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.cantidad * Peso.GetCotizacion());
        }

        //genero comparadores y sobrecargo operadores

        public static bool operator ==(Dolar d1, Dolar d2) // sobrecargo == 
        {
            return (d1.GetCantidad() == d2.GetCantidad());
        }

         public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        // euro
        public static bool operator ==(Dolar d, Euro e) // si la cantidad de dolares es igual a la cantidad de euros convertidos a dolares
        {
            return (d.GetCantidad() == ((Dolar)e).GetCantidad());
        }

        public static bool operator !=(Dolar d, Euro e) // sobrecargo == 
        {
            return !(d == e);
        }

        // peso

        public static bool operator ==(Dolar d, Peso p) // si la cantidad de dolares es igual a la cantidad de pesos convertidos a dolares
        {
            return (d.GetCantidad() == ((Dolar)p).GetCantidad());
        }

        public static bool operator !=(Dolar d, Peso p) // sobrecargo == 
        {
            return !(d == p);
        }

        // Euro
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)e).GetCantidad()); // retorna la resta entre las cantidades de dolares y Euros convertidos a dolar
        }

        // Peso
        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)p).GetCantidad()); // retorna la resta de dolares y pesos convertidos a dolar
        }


        // Euro
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)e).GetCantidad()); // retorna la SUMA entre las cantidades de dolares y Euros convertidos a dolar
        }

        // Peso
        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)p).GetCantidad()); // retorna la SUMA de dolares y pesos convertidos a dolar
        }

    }

}
