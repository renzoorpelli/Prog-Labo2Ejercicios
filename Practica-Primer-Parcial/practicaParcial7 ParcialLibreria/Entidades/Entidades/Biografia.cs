using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biografia : Publicacion
    {

        //constructores
        public Biografia (string nombre) :base(nombre)
        {

        }

        public Biografia(string nombre, int stock) : base(nombre, stock)
        {

        }
        public Biografia(string nombre, int stock, float valor) : base(nombre, stock, valor)
        {

        }


        //propiedades
        protected override bool EsColor 
        { 
            get
            {
                return false;
            }
        }

        public override bool HayStock
        {
            get 
            { 
                return stock > 0; 
            }
        }

        //conversiones
        public static explicit operator Biografia(string nombre)
        {
            return new Biografia(nombre);
        }
    }
}
