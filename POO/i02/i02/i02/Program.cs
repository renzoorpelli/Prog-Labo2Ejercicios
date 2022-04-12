using System;
using Entidades;

namespace i02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Renzo", 42444333, "18/11/2002");
            Persona p2 = new Persona("Renzo", 44333222, "14/06/2000");
            Persona p3 = new Persona("Renzo", 48338667, "11/01/2007");

            Console.WriteLine(p1.Mostrar());
            Console.WriteLine(p2.Mostrar());
            Console.WriteLine(p3.Mostrar());
        }
    }
}
