using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ETipo { Tubo, Plasma, Led}
    public class Televisor : Producto
    {
        public ETipo tipo;

        //Constructores
        public Televisor(string modelo, string marca, Epais pais, ETipo tipo) :base(modelo, marca, pais)
        {
            this.tipo = tipo;
        }

        // sobrecarga
        public static bool operator ==(Televisor a, Televisor b)
        {
            return (Producto)a == (Producto)b && a.tipo == b.tipo;
        }
        public static bool operator !=(Televisor a, Televisor b)
        {
            return !(a == b);
        }

        public static explicit operator Double(Televisor tv)
        {
            return tv.precio;
        }
        //conversiones
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((String)this);
            sb.Append($"TIPO: {this.tipo}\n");
            return sb.ToString();
        }


    }

    
}
