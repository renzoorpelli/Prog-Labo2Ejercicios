using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Celular : Producto
    {
        protected int megaPixelesCamara;

        public Celular(string modelo,int precio, EMarca marca,int megaPixelesCamara) :base(modelo,precio,marca)
        {
            this.megaPixelesCamara = megaPixelesCamara;
        }
        /// <summary>
        /// asigna un string segun el criterio de garantia del producto
        /// </summary>
        public override string Garantia
        {
            get
            {
                if (marca == EMarca.MarcaNoInformada)
                {
                    return "Garantia 12 meses";
                }
                else if(!(marca == EMarca.MarcaNoInformada) && !(marca == EMarca.Noblex))
                {
                    if(megaPixelesCamara > 12)
                    {
                        return "Garantia 36 meses";
                    }
                }
                return "Garantia 24 meses";
            }
        
        }
        /// <summary>
        /// le asigno 5 al porcentaje de descuento
        /// </summary>
        public override int PorcentajeDescuento
        {
            get
            {
                return 5;
            }
        }

        /// <summary>
        /// sobrecargo el metodo toString para que devuelva toda la informacion del Celular
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{base.ToString()}\nMEGAPIXELES {this.megaPixelesCamara}\n\n";
        }



    }
}
