using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ETipo { Tecnico, Escolar, Finanzas}
    public class Manual : Libro
    {
        public ETipo tipo;

        public Manual(string titulo, string apellido, string nombre, float precio, ETipo tipo) :base(titulo, apellido, nombre, precio)
        {
            this.tipo = tipo;
        }
        /// <summary>
        /// se castea los manuales a libros para poder tener acceso a la sobrecarga del operador == y comparar las propiedades y ahora sumandole que sean del mismo tipo
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator ==(Manual m1, Manual m2)
        {
            return (Libro)m1 == (Libro)m2 && m1.tipo == m2.tipo;
        }


        public static bool operator !=(Manual m1, Manual m2)
        {
            return !(m1 == m2);
        }
        /// <summary>
        /// recibe un manual y retorna el precio del mismo
        /// </summary>
        /// <param name="m"></param>
        public static explicit operator Single(Manual m)
        {
            return m.precio;
        }

        public override bool Equals(object obj)
        {
            Manual m = obj as Manual;
            return m is not null && this == (Manual)obj;
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append((String)this);
            sb.AppendLine($"TIPO: {this.tipo}");
            sb.AppendLine("*** FIN LIBRO***");

            return sb.ToString();
        }
        
    

    }
}
