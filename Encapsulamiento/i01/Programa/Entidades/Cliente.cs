using System;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente( int numero)
        {
            this.numero = numero;
        }

        public Cliente(string nombre, int numero) :this(numero) // sobrecargo
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Numero { get => numero; }


        // sobrecargas

        public static bool operator == (Cliente c1, Cliente c2)
        {
            return c1.numero == c2.numero;
        }
        public static bool operator != (Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

    }
}
