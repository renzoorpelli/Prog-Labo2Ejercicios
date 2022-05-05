using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ELibro { PrecioManuales, PrecioNovelas, PrecioTotal }
    public class Biblioteca
    {
        private int capacidad;
        private List<Libro> libros;

        private Biblioteca()
        {
            this.libros = new List<Libro>();
        }

        private Biblioteca(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }

        ////propiedades

        public double PrecioManuales
        {
            get
            {
                return ObtenerPrecio(ELibro.PrecioManuales);
            }
        }
        public double PrecioNovelas
        {
            get
            {
                return ObtenerPrecio(ELibro.PrecioNovelas);
            }
        }
        public double PrecioTotal
        {
            get
            {
                return ObtenerPrecio(ELibro.PrecioManuales) + ObtenerPrecio(ELibro.PrecioNovelas);
            }
        }

        //metodos
        /// <summary>
        /// muestro todo el contenido de cada libro utilizando el casteo explicito a (string) el cual devuelve la informacion
        /// y le adjunto la informacion complementaria dependiendo si es novela o manual con el metodo ToString() al final
        /// que esta sobrecargado en cada clase
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string MostrarBiblioteca(Biblioteca b)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Capacidad: {b.capacidad}");
            sb.AppendLine($"Total por Novelas: ${b.PrecioNovelas}");
            sb.AppendLine($"Total por Manuales: ${b.PrecioManuales}");
            sb.AppendLine($"Total: ${b.PrecioTotal}");
            sb.AppendLine("---------------LISTADO DE LIBROS-----------------");
            foreach (Libro libro in b.libros)
            {
                sb.AppendLine((String)libro.ToString());
            }
            return sb.ToString();
        }

        private  double ObtenerPrecio(ELibro tipoLibro)
        {
            double precioTotal = 0;
            foreach (Libro libro in this.libros)
            {
                if (tipoLibro == ELibro.PrecioManuales && libro is Manual)
                {
                    precioTotal += (float)(Manual)libro;
                    
                }
                else if (tipoLibro == ELibro.PrecioNovelas && libro is Novela)
                {
                    precioTotal += (float)(Novela)libro;
                    
                }  
            }
            return precioTotal;
        }

        //sobrecarga operadores

        public static implicit operator Biblioteca(int capacidad)
        {
            return new Biblioteca(capacidad);
        }

        public static bool operator ==(Biblioteca b, Libro I)
        {
            if ((b is not null) && (I is not null))
            {
                foreach (Libro item in b.libros)
                {
                    if (item is Manual && I is Manual)
                    {
                        if ((Manual)item == (Manual)I)
                            return true;

                    }
                    else if (item is Novela && I is Novela)
                    {
                        if ((Novela)item == (Novela)I)
                            return true;
                    }
                }
            }

            return false;
        }

        public static bool operator !=(Biblioteca b1, Libro l1)
        {
            return !(b1 == l1);
        }

        public static Biblioteca operator +(Biblioteca b1, Libro l1)
        {
            if (b1 != l1 && b1.capacidad - b1.libros.Count >= 1)
            {
                b1.libros.Add(l1);

            }
            else if(b1 == l1)
            {
                Console.WriteLine($"El libro esta en la biblioteca");
            }
            else
            {
                Console.WriteLine($"No hay mas lugar en la biblioteca");
            }
            return b1;
        }

    }
}
