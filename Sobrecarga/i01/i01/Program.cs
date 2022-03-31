using System;
using Entidades;
namespace i01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Sumador sumador2 = new Sumador(2);
            // muestra la suma
            Console.WriteLine(sumador.Sumar(45, 2));
            //muestra la concatenacion de strings
            Console.WriteLine(sumador.Sumar("renzo ", "orpelli"));



            // muestra la cantidad de sumas que hizo el metodo
            int cantidadSumas = (int)sumador;
            Console.WriteLine(cantidadSumas);

            //suma la cantidad de sumas de ambos metodos
            Console.WriteLine(sumador + sumador2);
            // compara el contenido
            Console.WriteLine(sumador | sumador2); 
        }
    }
}
