using System;
using Entidades;


namespace i01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente persona1 = new Cliente("Pedrito", 20000f);

            //Console.WriteLine($"SALDO: { persona1.GetMontoCuenta()}");
            Console.WriteLine($"{ persona1.MostrarEstadoCuenta(persona1)}");
            persona1.IngresarDinero(30000);
            Console.WriteLine($"{ persona1.MostrarEstadoCuenta(persona1)}");
            persona1.RetirarDinero(2000);
            Console.WriteLine($"{ persona1.MostrarEstadoCuenta(persona1)}");

        }
    }
}
