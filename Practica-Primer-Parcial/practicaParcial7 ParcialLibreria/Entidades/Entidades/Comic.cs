using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comic : Publicacion
    {
        private bool esColor;

        //propiedades
        protected override bool EsColor
        {
            get { return esColor; }
        }
        //propiedades
        public Comic(string nombre, bool esColor, int stock, float valor): base(nombre, stock, valor)
        {
            this.esColor = esColor;
        }
    }
}
