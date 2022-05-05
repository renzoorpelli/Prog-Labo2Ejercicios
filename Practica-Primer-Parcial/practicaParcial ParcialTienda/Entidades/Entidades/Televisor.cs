using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Televisor : Producto
    {
        protected bool esSmart;

        public Televisor(string modelo, int precio, EMarca marca, bool esSmart) 
            :this(modelo, precio, esSmart)
        {
            this.marca = marca;
        }

        public Televisor(string modelo, int precio, bool esSmart): base (modelo, precio)
        {
            this.esSmart=esSmart;
        }

        /// <summary>
        /// le asigno 5 al porcentaje de descuento
        /// </summary>
        public override int PorcentajeDescuento
        {
            get
            {
                return 10;
            }
        }

        /// <summary>
        /// asigna un string segun el criterio de garantia del producto
        /// </summary>
        public override string Garantia
        {
            get
            {
                if (esSmart == true)
                {
                    return "Garantia 48 meses";
                }
                return "Garantia 36 meses";
            }

        }
        /// <summary>
        /// devuelve la informacion del televisor
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()}\nES SMART: {this.esSmart}\n\n";
        }


    }
}
