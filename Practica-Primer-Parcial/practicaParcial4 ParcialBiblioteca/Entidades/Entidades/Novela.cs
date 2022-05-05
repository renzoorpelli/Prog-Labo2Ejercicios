using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EGenero { Accion, Romantica, CienciaFiccion }
    public class Novela : Libro
    {
        private EGenero genero;


        public Novela(string titulo, float precio, Autor autor, EGenero genero) :base(precio, titulo, autor)
        {
            this.genero = genero;
        }
        public static bool operator ==(Novela n1, Novela n2)
        {
            return (Libro)n1 == (Libro)n2 && n1.genero == n2.genero;
        }

        public static bool operator !=(Novela n1, Novela n2)
        {
            return !(n1 == n2);
        }

        public override bool Equals(object obj)
        {
            Novela m = obj as Novela;
            return m is not null && this == (Novela)obj;
        }

        public static implicit operator Single(Novela n)
        {
            return n.precio;
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append((String)this);
            sb.AppendLine($"GENERO: {this.genero}");
            sb.AppendLine("*** FIN LIBRO***");

            return sb.ToString();
        }

    }
}
