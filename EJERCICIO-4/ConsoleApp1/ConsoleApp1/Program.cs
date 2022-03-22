using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 8128;
            string confirmar;

            do
            {
                numeroPerfecto(numero);
                Console.WriteLine("Desea salir? (si/no)");
                confirmar = Console.ReadLine();

            } while (confirmar != "si");

        }

        static void numeroPerfecto(int num)
        {
            int acumulador;
            for (int i = 1; i <= num; i++)
            {
                acumulador = 0;

                for (int j = 1; j <= (i / 2); j++)
                {
                    if (i % j == 0)
                    {
                        acumulador += j;
                    }
                }
                if (acumulador == i)
                    Console.WriteLine($"El numero {i} es perfecto");
            }

        }
    }
}
