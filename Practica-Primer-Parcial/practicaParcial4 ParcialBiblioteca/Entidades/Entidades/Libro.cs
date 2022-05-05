using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Libro
    { 
        //atribtuos
        protected Autor autor;
        protected int cantidadPaginas;
        protected static Random generadorPaginas;
        protected float precio;
        protected string titulo;

        //constructores
        static Libro()
        {
            generadorPaginas = new Random();
        }
        public Libro(float precio, string titulo, Autor autor)
        {
            this.precio = precio;
            this.titulo = titulo;
            this.autor = autor;
        }

        /// <summary>
        /// Instancio un nuevo autor con la palabra reservada new y le paso el nombre y el apellido
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        public Libro(string titulo, string apellido, string nombre, float precio) : this(precio, titulo, new Autor(apellido, nombre))
        {
        }

        //PROPIEDAD
        public int CantidadPaginas 
        {
            get 
            {
                if(this.cantidadPaginas == 0)
                {
                    this.cantidadPaginas = generadorPaginas.Next(10, 570);    
                }
                return cantidadPaginas; 
            }
        }

        //SOBRECARGA
        public static bool operator ==(Libro l1, Libro l2)
        {
            return l1.autor == l2.autor && l1.titulo == l2.titulo;
        }


        public static bool operator !=(Libro l1, Libro l2)
        {
            return !(l1 == l2);
        }

        // metodo
        /// <summary>
        /// recibe un libro y muestra los detalles del libro, en autor uso el casteo explicito que me devuelve el nombre y el apellido del autor
        /// </summary>
        /// <param name="l"></param>
        /// <returns>retorna los detalles del libro en un string builder</returns>
        private static string Mostrar(Libro l)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*** INICIO LIBRO***");
            sb.AppendLine($"AUTOR: {(string)l.autor}");
            sb.AppendLine($"CANTIDAD PAGINAS: {l.CantidadPaginas}");
            sb.AppendLine($"PRECIO: ${l.precio}");
            sb.AppendLine($"TITULO: {l.titulo}");
            return sb.ToString();
        }

        public static explicit operator String(Libro l)
        {
            return Libro.Mostrar(l);
        }
    }
}
