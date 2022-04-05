using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero;
            float max = 0;
            float min= 0;
            float promedio;
            bool validar;
            float acumulador = 0;



            for (int i = 0; i < 5; i++)
            {
             
                do {
                    Console.WriteLine("Ingrese un numero: ");
                    validar = float.TryParse(Console.ReadLine(), out numero);

                } while (!validar);

                if (i==0)
                {
                    min = numero;
                    max = numero;
                }
                if (numero > max)
                    max = numero;

                if (numero < min)
                    min = numero;

                acumulador += numero;

            }
            promedio = acumulador / 5;

            Console.WriteLine($"El numero maximo es {max}, el numero minimo es {min} y el promedio de la suma da como resultado {promedio}");

        }
    }
}
