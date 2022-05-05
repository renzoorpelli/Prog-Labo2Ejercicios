using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EGama { Baja, Media, Alta }
    public class Celular : Producto
    {
        public EGama gama;

        //Constructores
        public Celular (string modelo, Fabricante fabricante, EGama gama) : base(modelo,fabricante)
        {
            this.gama = gama;
        }
        //sobrecarga
        // sobrecarga
        public static bool operator ==(Celular a, Celular b)
        {
            return (Producto)a == (Producto)b && a.gama == b.gama;
        }
        public static bool operator !=(Celular a, Celular b)
        {
            return !(a == b);
        }

        public static implicit operator Double(Celular c)
        {
            return c.precio;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((String)this);
            sb.Append($"GAMA: { this.gama}\n");
            return sb.ToString();
        }
    }
}
