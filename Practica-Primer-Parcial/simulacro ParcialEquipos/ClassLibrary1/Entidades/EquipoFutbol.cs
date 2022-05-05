using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipoFutbol : Equipo
    {
        protected bool jugadorEstrella;

        public EquipoFutbol(string nombre) : this(nombre, false)
        {

        }

        public EquipoFutbol(string nombre, bool jugadorEstrella) : base(nombre)
        {
            this.jugadorEstrella = jugadorEstrella;
        }

        public override int GetDificultad()
        {
            Random random = new Random();

            if (jugadorEstrella == true)
            {
                return random.Next(7, 10) * 2;
            }
            
            return random.Next(7, 10);
        }

        protected override string MostrarDatos()
        {// hay que usar strinbuilder
            return $"Futbol -{base.MostrarDatos()}"; 
        }

        public override string ToString()
        {
            return base.ToString() + this.MostrarDatos();
        }
    }
}
