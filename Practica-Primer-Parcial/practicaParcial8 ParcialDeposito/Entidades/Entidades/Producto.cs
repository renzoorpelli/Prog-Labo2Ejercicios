using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        protected Fabricante fabricante;
        protected static Random generadorDePrecios;
        protected string modelo;
        protected int precio;

        //CONSTRUCTORES
        static Producto()
        {
            generadorDePrecios = new Random();
        }
        public Producto(string modelo, Fabricante fabricante)
        {
            this.modelo = modelo;
            this.fabricante = fabricante;

        }
        public Producto(string modelo, string marca, Epais pais)
            : this(modelo, new Fabricante(marca, pais))
        {

        }
        //PROPIEDAD 
        public int Precio
        {
            get
            {
                if (this.precio == 0)
                {
                    this.precio = generadorDePrecios.Next(10500, 125000);
                }
                return precio;

            }
        }

        //SOBRECARGA
        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1.modelo == p2.modelo && p1.fabricante == p2.fabricante;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static explicit operator String(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            if (p is not null)
            {
                sb.AppendLine($"FABRICANTE: {(String)p.fabricante}");
                sb.AppendLine($"PRECIO: ${p.Precio}");
                sb.AppendLine($"MODELO: {p.modelo}");
            }
            return sb.ToString();

        }



    }
}
