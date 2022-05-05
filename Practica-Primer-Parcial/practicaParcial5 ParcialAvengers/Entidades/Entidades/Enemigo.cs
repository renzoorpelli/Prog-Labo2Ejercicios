using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enemigo : Personaje
    {
        private string objetivo;

        public Enemigo(string nombre, List<EHabilidades> habilidades, string objetivo) : base(nombre, habilidades)
        {
            this.objetivo = objetivo;
        }
        // propiedad
        protected override string Nombre
        {
            get
            {
                return $"Soy {base.Nombre} y los voy a hacer puré";
            }
        }
        //sobrecarga
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("OBJETIVO: ");
            sb.Append(objetivo);
            return sb.ToString();
        }
    }
}
