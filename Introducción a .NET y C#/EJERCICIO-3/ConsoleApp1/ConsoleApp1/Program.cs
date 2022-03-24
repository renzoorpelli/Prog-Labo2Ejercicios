using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            bool numeroValido;
            string continuar;

            do
            {
                Console.WriteLine("Ingrese un numero");
                numeroValido = int.TryParse(Console.ReadLine(), out numero);
                while (!numeroValido)
                {
                    Console.WriteLine("Ingrese un numero");
                    numeroValido = int.TryParse(Console.ReadLine(), out numero);

                }
                esPrimo(numero);
                Console.WriteLine("Desea ingresar otro numero? de lo contrario ingrese 'salir'");
                continuar = Console.ReadLine();
             
            } while (continuar != "salir");

        }

            static void esPrimo(int num1) 
            {
                bool todoOk = true;
                for (int i = 2; i<=num1; i++)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if(i % j == 0)
                        {
                            todoOk = false;
                            break;
                        }

                    }
                    if (todoOk)
                    {
                        Console.WriteLine($"El numero {i} es primo");
                    }
                    todoOk = true;  
                }
            }

        }
 }

    

