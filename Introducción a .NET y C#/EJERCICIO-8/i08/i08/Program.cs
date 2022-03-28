using System;

namespace i08
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
                for (int j = i; j <= numero; j++)
                {
                    Console.Write(" ");
                    
                }
                for (int j = 1; j <= (2*i -1) ; j++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine("");
            }
        }
    }
}
