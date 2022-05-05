using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EProducto { PrecioDeTelevisores, PrecioDeCelulares, PrecioTotal }
    public class Deposito
    {
        private int capacidad;
        private List<Producto> productos;

        //Constructores
        private Deposito()
        {
            productos = new List<Producto>();
        }

        private Deposito(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }

        //PROPIEDADES
        public double PrecioTelevisores
        {
            get
            {
                return ObtenerPrecio(EProducto.PrecioDeTelevisores);
            }
        }
        public double PrecioCelualares
        {
            get
            {
                return ObtenerPrecio(EProducto.PrecioDeCelulares);
            }
        }
        public double PrecioTotal
        {
            get
            {
                return ObtenerPrecio(EProducto.PrecioDeTelevisores) + ObtenerPrecio(EProducto.PrecioDeCelulares);
            }
        }

        // metodos
        private double ObtenerPrecio(EProducto tipoProducto)
        {
            int precioTotal = 0;
            foreach (Producto producto in productos)
            {
                if (tipoProducto == EProducto.PrecioDeCelulares && producto is Celular)
                {
                    precioTotal += producto.Precio;
                    

                }
                else if (tipoProducto == EProducto.PrecioDeTelevisores && producto is Televisor)
                {
                    precioTotal += producto.Precio;

                }
            }
            return precioTotal;
        }
        public static string MostrarDeposito(Deposito b)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Capacidad: {b.capacidad}");
            sb.AppendLine($"Total por Televisores: ${b.PrecioTelevisores}");
            sb.AppendLine($"Total por Celulares: ${b.PrecioCelualares}");
            sb.AppendLine($"Total: ${b.PrecioTotal}");
            sb.AppendLine("---------------LISTADO DE PRODUCTOS-----------------");
            foreach (Producto p in b.productos)
            {
                sb.AppendLine((String)p.ToString());
            }
            return sb.ToString();
        }
        // sobrecargas
        public static implicit operator Deposito(int capacidad)
        {
            return new Deposito(capacidad);
        }

        public static bool operator ==(Deposito b, Producto I)
        {
            if ((b is not null) && (I is not null))
            {
                foreach (Producto item in b.productos)
                {
                    if (item is Televisor && I is Televisor)
                    {
                        if ((Televisor)item == (Televisor)I)
                            return true;

                    }
                    else if (item is Celular && I is Celular)
                    {
                        if ((Celular)item == (Celular)I)
                            return true;
                    }
                }
            }

            return false;
        }
        public static bool operator !=(Deposito b, Producto I)
        {
            return !(b == I);
        }

        public static Deposito operator +(Deposito b1, Producto l1)
        {
            if (b1 != l1 && b1.capacidad - b1.productos.Count >= 1)
            {
                b1.productos.Add(l1);

            }
            else if (b1 == l1)
            {
                Console.WriteLine($"El producto se encuentra en el deposito");
            }
            else
            {
                Console.WriteLine($"No hay mas lugar en el Deposito");
            }
            return b1;
        }

    }
}
