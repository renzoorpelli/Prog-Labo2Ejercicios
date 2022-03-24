using System;
using LogicaNegocio;

namespace i01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int acumulador = 0;
            int numeroMinimo = 0;
            int numeroMaximo = 0;
            int promedio;
            
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero");
                bool isNumber = int.TryParse(Console.ReadLine(), out numero);

                while (!isNumber || !(Validador.Validar(numero, -100, 100)))
                {
                    Console.WriteLine("Ingrese un numero valido");
                    isNumber = int.TryParse(Console.ReadLine(), out numero);
                }

                acumulador += numero;
                if(i == 0)
                {
                    numeroMaximo = numero;
                    numeroMinimo = numero;
                }

                if (numero > numeroMaximo)
                    numeroMaximo = numero;

                if (numero < numeroMinimo)
                    numeroMinimo = numero;
            }

            promedio = acumulador / 10;

            Console.WriteLine($"El numero maximo es {numeroMaximo}, el numero minimo es {numeroMinimo} y el promedio de la suma da como resultado {acumulador}");

        }
    }
}
