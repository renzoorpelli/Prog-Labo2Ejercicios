using System;
using Entidades;
namespace libros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro();

            libro1[0] = "pepito iv";
            libro1[1] = "juancito v";

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(libro1[i]);
            }

            libro1[1] = "juancito v";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(libro1[i]);
            }

        }
    }
}
