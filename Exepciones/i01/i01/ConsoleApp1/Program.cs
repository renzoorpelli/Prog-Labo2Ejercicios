using System;
using Entidades;
namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            OtraClase otraClase;
            try
            {
                otraClase = new OtraClase();
                otraClase.MiMetodoInstancia();
            }
            catch (MiExcepcion ex)
            {
                Console.WriteLine($"mensaje ex.Message");
                Console.WriteLine(ex.Message);
                Exception exInner = ex.InnerException;
                while (exInner != null)
                {
                    Console.WriteLine(exInner.Message);
                    exInner = exInner.InnerException;
                }
            }
        }
    }
}
