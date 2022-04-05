using System;

namespace i09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingrese el numero de filas ");
            int.TryParse(Console.ReadLine(), out numero);

            for (int i = 1; i <= numero; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }
    }
}
