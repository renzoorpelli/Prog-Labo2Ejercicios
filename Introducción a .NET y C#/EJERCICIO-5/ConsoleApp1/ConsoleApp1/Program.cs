using System;
// ejercicio 5
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;

            Console.WriteLine("Ingrese numero");
            
            while(int.TryParse(Console.ReadLine(), out numeroIngresado))
            {
                for (int i = 1; i < numeroIngresado; i++)// itero desde el 1 hasta el numero ingresado
                {
                    int sumadorInferior = 0; // creo variable para los inferiores al centro
                    for (int j = 0; j < i; j++)// recorro los inferiores
                    {
                        sumadorInferior += j;// summo los inferiores al centro

                    }


                    int sumadorSuperior = 0;// creo variable para los superiores al centro
                    for (int k = i + 1; k < sumadorInferior; k++)// reccorro los superirores
                    {
                        if ((sumadorInferior == sumadorSuperior) || (sumadorSuperior > sumadorInferior))
                            break;

                        sumadorSuperior += k;
                    }
                    // cuando sean igulaes muestros
                    if (sumadorInferior == sumadorSuperior)
                    {
                        Console.WriteLine($"Es un centro numerico de {i}");
                    }

                }
            }
            Console.ReadKey();
           
            
        }  
    }
}
