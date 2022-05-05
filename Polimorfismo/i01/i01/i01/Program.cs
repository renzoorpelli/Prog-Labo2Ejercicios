using System;
using Entidades;

namespace i01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Sobre-Sobrescrito";
            Sobrescrito objetosobreescrito = new SobreSobreescrito(); 

            Console.WriteLine(objetosobreescrito.MiMetodo());

            string objeto = "¡Este es mi método ToString sobrescrito!";

            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(objetosobreescrito.Equals(objeto));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetosobreescrito.GetHashCode());

            Console.ReadKey();
        }
    }
}
