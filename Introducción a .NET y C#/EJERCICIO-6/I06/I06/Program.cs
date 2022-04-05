using System;

/*
 * Escribir un programa que determine si un año es bisiesto.

Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.

Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
 */
namespace I06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroInicio;
            int numeroFinal;
            bool isNumberInicio;
            bool isNumberFinal;


            Console.WriteLine("Ingrese año de inicio:");
            isNumberInicio = int.TryParse(Console.ReadLine(), out numeroInicio);
            Console.WriteLine("Ingrese año final:");
            isNumberFinal = int.TryParse(Console.ReadLine(), out numeroFinal);

            for (int bisiesto = numeroInicio; bisiesto <= numeroFinal; bisiesto++)
            {
                if (bisiesto % 4 == 0 || bisiesto % 400 == 0)
                {
                    Console.WriteLine($"el año {bisiesto} es bisiesto");

                }

            }

        }
    }
}


/*
  for (int i = 0; i < numeroInicio; i++)
                {
                    for (int bisiesto = numeroInicio + 1 ; bisiesto < numeroFinal; bisiesto++)
                    {
                        if (bisiesto % 4 == 0)
                        {
                            if (bisiesto >= numeroFinal)
                            {
                                Console.WriteLine(los anos bisiestos son {bisiesto);
                                break;
                            }
                                
                        }
                        
                    }
                    
                }
 */