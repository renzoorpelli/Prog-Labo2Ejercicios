using System;
using Validador;
namespace i02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char continuar = 'n';
            bool isChar;


            do
            {
                Console.WriteLine("Desea continuar? (s/n)");
                isChar = char.TryParse(Console.ReadLine(), out continuar);

                while (!isChar || Validar.ValidarRespuesta(continuar))
                {
                    Console.WriteLine("Desea continuar? (s/n)");
                    isChar = char.TryParse(Console.ReadLine(), out continuar);
                }

            }while (continuar != 'n');
        }
    }
}
