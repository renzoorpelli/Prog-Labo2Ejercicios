using System;
using System.Text;
using Entidades;

namespace a01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conductor[] conductores = new Conductor[3];
            for (int i = 0; i < conductores.Length; i++)
            {
                conductores[i] = new Conductor();
            }
            conductores[0].SetNombreConductor("renzo");
            conductores[1].SetNombreConductor("pepito");
            conductores[2].SetNombreConductor("minguito");

            for (int i = 1; i <= 7; i++)
            {
                conductores[0].SetKilometros(20, i);
                conductores[1].SetKilometros(30, i);
                conductores[2].SetKilometros(40, i);
            }

            Console.WriteLine(Conductor.MostrarConductor(conductores[0]));
            Console.WriteLine(Conductor.MostrarConductor(conductores[1]));
            Console.WriteLine(Conductor.MostrarConductor(conductores[2]));


            Console.WriteLine(CalcularMayorKilometors(conductores[0], conductores[1], conductores[2]));
        }

        static string CalcularMayorKilometors(Conductor a, Conductor b, Conductor c)
        {
            string mayor;
            StringBuilder sb = new StringBuilder();
            if (a.GetKilometros() > b.GetKilometros() &&  a.GetKilometros() > c.GetKilometros())
            {
                mayor = $"{a.GetNombre()}";
            }
            else if(b.GetKilometros() > c.GetKilometros() && b.GetKilometros() > a.GetKilometros())
            {
                mayor = $"{b.GetNombre()}";
            }
            else
            {
                mayor = $"{c.GetNombre()}";
            }
            sb.AppendLine($"El conductor con mayor kilometraje es {mayor}");
            
            return sb.ToString();
        }
    }
}
