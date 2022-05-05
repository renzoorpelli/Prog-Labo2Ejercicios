using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipoBasket : Equipo
    {
        protected enum Eliga
        {
            NBA,Euroleague,ACB
        }
        private Eliga liga;

        public EquipoBasket(string nombre) : base(nombre)
        {
           
        }

        protected EquipoBasket(string nombre, Eliga liga) : this(nombre)
        {
            this.liga = Eliga.NBA;
        }

        public override int GetDificultad()
        {
            Random random = new Random();
            
            if (liga == Eliga.NBA)
            {
                return random.Next(8,10);
            }
            else if(liga == Eliga.ACB)
            {
                return random.Next(1, 7);
            }
            else if(liga==Eliga.Euroleague)
            {
                return random.Next(5, 10);
            }
            return 0;
        }

        protected override string MostrarDatos()
        {
            return $"Basket- {base.MostrarDatos()}\n"; //LIGA: {this.liga}
        }

        public override string ToString()
        {
            return base.ToString() + this.MostrarDatos();
        }

    }
}
