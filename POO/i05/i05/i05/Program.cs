using System;
using Entidades;

namespace i05
{
    public class Program
    {
        static void Main(string[] args)
        {
            Punto punto1 = new Punto(2, 1);
            Punto punto2 = new Punto(3, 4);
            Rectangulo rec1 = new Rectangulo(punto1, punto2);

            Console.WriteLine(MostrarRectangulo(rec1));
        }

        static string MostrarRectangulo(Rectangulo rectangulo)
        {
            return $"El Area : {rectangulo.Area()} y  el Perimetro : {rectangulo.Perimetro()}";
        }

    }
}
