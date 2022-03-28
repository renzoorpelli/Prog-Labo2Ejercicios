using System;
using Calculadora;

namespace i03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            bool isNumber;
            string decimalToBinary = string.Empty;
            int binaryToDecimal;
            int opcion;
            bool validOption;

            Console.WriteLine(" Bienvenido al conversor, ingrese 1 si quiere convertir un decimal a binario o  2 si quiere convertir un binario a decimal");
            validOption = int.TryParse(Console.ReadLine(), out opcion);
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese un numero DECIMAL: ");
                    isNumber = int.TryParse(Console.ReadLine(), out numeroIngresado);
                    if (Conversor.isNumberValid(numeroIngresado) == true)
                    {
                        decimalToBinary = Conversor.ConvertirDecimalABinario(numeroIngresado);
                        
                        Console.WriteLine($"El numero ingresado fue {numeroIngresado} y en binario es {decimalToBinary}");
                    }
                    break;
                    case 2:
                    Console.WriteLine("Ingrese un numero BINARIO: ");
                    isNumber = int.TryParse(Console.ReadLine(), out numeroIngresado);
                    if (Conversor.isNumberValid(numeroIngresado) == true)
                    {
                        binaryToDecimal = Conversor.ConvertirBinarioADecimal(numeroIngresado);

                        Console.WriteLine($"El numero ingresado fue {numeroIngresado} y en binario es {binaryToDecimal}");
                    }
                    break;
                default:
                    Console.WriteLine("opcion no valida");
                    break;
            }

           
        }
    }
}
