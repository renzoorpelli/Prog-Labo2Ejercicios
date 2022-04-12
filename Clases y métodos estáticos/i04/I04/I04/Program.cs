using System;
using Entidades;

namespace I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float operando1 = 0;
            float operando2 = 0;
            int flagOperando = 0;
            float resultado;
            char seguir = 's';
            char salir = 's';
            char operandoCalcular = 's';
            

            do
            {
                switch(Menu(operando1, operando2, operandoCalcular))
                {
                    case 1:
                        Console.WriteLine("ingrese numero");
                        bool isNumber1 = float.TryParse(Console.ReadLine(), out operando1);
                        while(!isNumber1)
                        {
                            Console.WriteLine("ingrese operando valido");
                            isNumber1 = float.TryParse(Console.ReadLine(), out operando1);
                        }
                        flagOperando = 1;
                        break;
                    case 2:
                        Console.WriteLine("ingrese numero");
                        bool isNumber2 = float.TryParse(Console.ReadLine(), out operando2);
                        while (!isNumber2)
                        {
                            Console.WriteLine("ingrese operando valido");
                            isNumber2 = float.TryParse(Console.ReadLine(), out operando2);
                        }
                        flagOperando = 2;
                        break;
                    case 3:
                        Console.WriteLine("ingrese operando");
                        bool isChar = char.TryParse(Console.ReadLine(), out operandoCalcular);
                        while (!isChar)
                        {
                            Console.WriteLine("Ingrese una operacion valida");
                            isChar = char.TryParse(Console.ReadLine(), out operandoCalcular);
                        }
                        break;
                    case 4:
                        if (flagOperando == 0)
                        {
                            Console.WriteLine("No ingresaste operandos");
                        }
                        else if (flagOperando == 1)
                        {
                            Console.WriteLine("Ingresaste un solo operando");
                        }
                        else {
                            resultado = Calculadora.Calcular(operando1, operando2, operandoCalcular);
                            Console.WriteLine($"La operacion da como resultado {resultado}");

                            }
                        break;
                    case 5:
                        Console.WriteLine("Desea salir? s/n");
                        salir = char.Parse(Console.ReadLine());
                        if (salir == 's')
                        {
                            seguir = 'n';
                        }
                        else
                        {
                            break;
                        }
                        break;
                    default:
                        Console.WriteLine("opcion ivalida");
                    break;
                }
               
            } while (seguir == 's');
        }

        static int Menu(float operando1, float operando2, char operandoCalcular)
        {
            int opcion;
            bool isValidOption;
            Console.WriteLine($"1) Ingrese el primer operando: {operando1}", operando1);
            Console.WriteLine($"2) Ingrese el segundo operando: {operando2}", operando2);
            Console.WriteLine($"3) Ingrese la operacion a calcular utilizando +, -, * o / : {operandoCalcular}");
            Console.WriteLine($"4) Resultado");
            Console.WriteLine($"5) Salir");
            isValidOption = int.TryParse(Console.ReadLine(), out opcion);
            while(!isValidOption)
            {
                Console.WriteLine("Ingrese opcion valida");
                isValidOption = int.TryParse(Console.ReadLine(), out opcion);
            }
            return opcion;
        }
    }
}
