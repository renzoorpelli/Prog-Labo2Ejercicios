using System;
//Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

//Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

//Calcular(público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. El método devolverá el resultado de la operación.

//Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.

//Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

//El usuario decidirá cuándo finalizar el programa.
namespace Entidades
{

    public class Calculadora
    {

        public static float Calcular(float operando1, float operando2, char operador)
        {
            float resultado = 0;

            switch (operador)
            { 
                case '+':
                        resultado = operando1 + operando2;
                break;
                case '-':
                        resultado = operando1 - operando2;
                break;
                case '*':
                        resultado = operando1 * operando2;
                break;
                case '/':
                    if (Validar(operando2))
                    {
                        resultado = operando1 / operando2;

                    }
                    else
                        Console.WriteLine("No es posible dividir por 0");
                break;
                default:
                    Console.WriteLine("Operacion invalida");
                    break;
            }
            return resultado;
        }

        private static bool Validar(float operando2)
        {
            bool todoOk = false;

            if(operando2 != 0)
            {
                todoOk = true;
            }

            return todoOk;
        }
    }
}
