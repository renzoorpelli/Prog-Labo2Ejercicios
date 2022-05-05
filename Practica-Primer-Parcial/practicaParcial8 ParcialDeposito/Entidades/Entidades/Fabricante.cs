using System;

namespace Entidades
{
    public enum Epais { Argentina, China, Holanda, USA, Corea}
    public class Fabricante
    {
        private string marca;
        private Epais pais;

        //CONSTRUCTORES
        public Fabricante(string marca, Epais pais)
        {
            this.marca = marca;
            this.pais = pais;
        }

        //Sobrecargas
        public static bool operator ==(Fabricante f1, Fabricante f2)
        {
            return f1.marca == f2.marca && f1.pais == f2.pais;
        }
        public static bool operator !=(Fabricante f1, Fabricante f2)
        {
            return !(f1 == f2);
        }
        public static implicit operator String(Fabricante f)
        {
            return f.marca + "-" + f.pais;
        }
    }
}
