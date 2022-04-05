using System;
using Entidades;
namespace i06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"AREA CUADRADO: {CalculadoraDeArea.CalcularAreaCuadrado(5)}");
            Console.WriteLine($"AREA TRIANGULO: {CalculadoraDeArea.CalcularAreaTriangulo(5, 3)}");
            Console.WriteLine($"AREA CIRCULO: {CalculadoraDeArea.CalcularAreaCirculo(5)}");
        }
    }
}
