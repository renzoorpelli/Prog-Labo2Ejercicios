using System;
using Entidades;
namespace Torneos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoBasket> torneoBasket = new Torneo<EquipoBasket>("Torneo pepito Basket");
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Torneo pablito Futbol");

            //-----------------EQUIPO BASKET--------------------
            EquipoBasket equipoBasket1 = new EquipoBasket("BULLS", new DateTime(1966, 01, 16));
            EquipoBasket equipoBasket2 = new EquipoBasket("GOLDEN STATE WARRIORS", new DateTime(1946, 04, 03));
            EquipoBasket equipoBasket3 = new EquipoBasket("MIAMI HEAT", new DateTime(1988, 04, 03));

            equipoBasket1 += torneoBasket;
            equipoBasket2 += torneoBasket;
            equipoBasket3 += torneoBasket;

            //-----------------EQUIPO FUTBOL--------------------
            EquipoFutbol equipoFutbol1 = new EquipoFutbol("BOCA", new DateTime(1905, 04, 03));
            EquipoFutbol equipoFutbol2 = new EquipoFutbol("RIVER", new DateTime(1901, 05, 25));
            EquipoFutbol equipoFutbol3 = new EquipoFutbol("ROSARIO CENTRAL", new DateTime(1889, 12, 24));

            equipoFutbol1 += torneoFutbol;
            equipoFutbol2 += torneoFutbol;
            equipoFutbol3 += torneoFutbol;


            //---------------Basket-----------------------------
            //muestro los equipos
            Console.WriteLine(torneoBasket.MostrarTorneo());
            //muestro el resultado del partido
            Console.WriteLine(torneoBasket.JugarPartido);
            Console.WriteLine(torneoBasket.JugarPartido);
            Console.WriteLine(torneoBasket.JugarPartido);

            Console.WriteLine("--------------------------------\n");
            //---------------Futbol-----------------------------
            //muestro los equipos
            Console.WriteLine(torneoFutbol.MostrarTorneo());
            //muestro el resultado del partido
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);

        }
    }
}
