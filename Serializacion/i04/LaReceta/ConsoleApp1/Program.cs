using System;
using Entidades;
namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("renzo", "orpelli");

            //Seralizadora seralizadora = new Seralizadora();

            Seralizadora.Leer_JSON("gonza");
        }
    }
}
