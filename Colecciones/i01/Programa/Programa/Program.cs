using System;

namespace Programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[20];
            Random random = new Random();

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                arrayNumeros[i] = random.Next(-100, 100);
            }

            Console.WriteLine("primer array");

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                Console.WriteLine($"{i}: {arrayNumeros[i]}");
            }


            Console.WriteLine("-------NUMEROS POSITIVOS: DECRECIENTE:-----------");
            Array.Sort(arrayNumeros, ordenDrecreciente);
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                if(arrayNumeros[i] > 0)
                {
                    Console.WriteLine($"{i}: {arrayNumeros[i]}");

                }
            }

            Console.WriteLine("-------NUMEROS NEGATIVOS: CRECIENTE:-----------");
            Array.Sort(arrayNumeros);
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                if (arrayNumeros[i] < 0)
                {
                    Console.WriteLine($"{i}: {arrayNumeros[i]}");

                }
            }

        }

        static int ordenDrecreciente(int a, int b)
        {
            return a - b;
        }
    }
}
