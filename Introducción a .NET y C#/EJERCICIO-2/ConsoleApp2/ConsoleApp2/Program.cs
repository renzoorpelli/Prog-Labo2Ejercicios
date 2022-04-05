using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool numeroValido;
            
            do
            {
                Console.WriteLine("Ingrese numero");
                numeroValido = int.TryParse(Console.ReadLine(), out numero);

            } while (!numeroValido && numero > 0);

            Console.WriteLine($"El numero ingresado es {numero}, al cuadrado seria {Math.Pow(numero, 2)} y al cubo seria {Math.Pow(numero, 3)}");
        }
    }
}
