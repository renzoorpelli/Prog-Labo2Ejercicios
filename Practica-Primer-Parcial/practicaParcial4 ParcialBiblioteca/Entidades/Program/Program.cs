using System;
using Entidades;
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca miBiblioteca = 5;
            Autor a = new Autor("Esteban", "Rey");
            Autor b = new Autor("Joe", "Mayo");
            Manual m1 = new Manual("Economia", "Domingo", "Caballo", 25f, ETipo.Finanzas);
            Novela n1 = new Novela("Miseria", 63.50f, a, EGenero.Romantica);
            Manual m2 = new Manual("C#", "Joe", "Mayo", 299.50f, ETipo.Tecnico);
            Novela n2 = new Novela("Miseria", 205f, a, EGenero.Accion);
            Novela n3 = new Novela("Miseria", 98f, a, EGenero.CienciaFiccion);
            Novela n4 = new Novela("Miseria", 103.50f, b, EGenero.Accion);
            miBiblioteca += m1;
            //YA INGRESADO
            miBiblioteca += m1;
            miBiblioteca += n1;
            miBiblioteca += m2;
            miBiblioteca += n2;
            miBiblioteca += n3;
            //SIN LUGAR
            miBiblioteca += n4;
            Console.WriteLine();
            //TRUE
            Console.WriteLine(m1.Equals(m1));
            //FALSE
            Console.WriteLine(m1.Equals("Joe Mayo"));
            //FALSE
            Console.WriteLine(m1.Equals(m2));
            //TRUE
            Console.WriteLine(n1.Equals(n1));
            //FALSE
            Console.WriteLine(n1.Equals(n2));
            //FALSE
            Console.WriteLine(n1.Equals(n4));
            Console.WriteLine("--------------------------------------------\n");
            Console.WriteLine(Biblioteca.MostrarBiblioteca(miBiblioteca));
            Console.ReadLine();
        }
    }
}
