using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contabilidad<T, U> where T : Documento
    where U : Documento, new()
    {
        private List<T> egresos = new List<T>();
        private List<U> ingresos = new List<U>();

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, T egreso)
        {
            if (c is not null && egreso is not null)
            {
                c.egresos.Add(egreso);
            }
            return c;
        }



        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            if (c is not null && ingreso is not null)
            {
                c.ingresos.Add(ingreso);
            }
            return c;
        }
    }
}
