using System;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotzRespectoDolar;
        //constructores
        static Peso()
        {
            cotzRespectoDolar = 1 / 102.65;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }


        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            Peso.cotzRespectoDolar = cotizacion;
        }

        // getters
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Peso.cotzRespectoDolar;
        }

        //
        public static implicit operator Peso(double peso)
        {
            return new Peso(peso);
        }


        // sobrecargas explicitas para Dolar y Euro

        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.GetCantidad() / Peso.GetCotizacion());
        }

        public static explicit operator Euro(Peso p)
        {
            return ((Euro)(Dolar)p); // re utilizo conversion explicita. Flujo de programa peso -> Dolar y el resultado a Euro
        }

        // sobrecargas para los comparadores y operadores aritmeticos

        public static bool operator ==(Peso p1, Peso p2) // sobrecargo == 
        {
            return p1.GetCantidad() == p2.GetCantidad();
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }

        // Dolar
        public static bool operator ==(Peso p, Dolar d) // si la cantidad de Pesos es igual a la cantidad de dolares convertidos a pesos
        {
            return p.GetCantidad() == ((Peso)d).GetCantidad();
        }

        public static bool operator !=(Peso p, Dolar d) // sobrecargo == 
        {
            return !(p == d);
        }


        // Euro
        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.GetCantidad() - ((Peso)e).GetCantidad()); // retorna la resta entre las cantidades de pesos y Euros convertidos a pesos
        }

        // Dolar
        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad() - ((Peso)d).GetCantidad()); // retorna la resta de pesos y dolares convertidos a pesos
        }


        // Euro
        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.GetCantidad() + ((Peso)e).GetCantidad()); // retorna la SUMA entre las cantidades de pesos y Euros convertidos a pesos
        }

        // Dolar
        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad() + ((Peso)d).GetCantidad()); // retorna la SUMA de pesos y dolares convertidos a pesos
        }

    }
}
