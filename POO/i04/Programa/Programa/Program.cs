using System;
using Entidades;
namespace Programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo a1 = new Boligrafo(50, ConsoleColor.Blue);
            
            Boligrafo a2 = new Boligrafo(30, ConsoleColor.Red);
            

            string s1 = string.Empty;
            string s2 = string.Empty;

            
            Console.WriteLine("LAPICERA ORIGINAL");
            Console.WriteLine(a1.Mostar());
            Console.WriteLine(a2.Mostar());

            a1.Recargar();
            a2.Recargar();

            Console.WriteLine("RECARGANDO TINTA");
            Console.WriteLine(a1.Mostar());
            Console.WriteLine(a2.Mostar());

            a1.Pintar(2, out s1);
            a2.Pintar(4, out s2);

            Console.WriteLine("PINTANDO");
            Console.WriteLine(a1.Mostar());
            Console.WriteLine(a2.Mostar());

            a1.SetTinta(-30);
            a2.SetTinta(-10);
            Console.WriteLine("SETEANDO TINTA - ");
            Console.WriteLine(a1.Mostar());
            Console.WriteLine(a2.Mostar());


            a1.SetTinta(30);
            a2.SetTinta(10);
            Console.WriteLine("SETEANDO TINTA + ");
            Console.WriteLine(a1.Mostar());
            Console.WriteLine(a2.Mostar());


        }
    }
}
