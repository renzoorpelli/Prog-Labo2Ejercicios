using System;
using System.Collections.Generic;
using System.Text;
namespace Entidades
{
    public enum EMarca { MarcaNoInformada, Samsung, LG, Sony, BGH, Noblex};
    public static class Tienda
    {
        public const int capacidadTienda = 10;
        static Random rnd = new Random();
        static List<Producto> list = new List<Producto>();


        static Tienda()
        {
            List<Producto> lista = new List<Producto>();
            Random rnd = new Random();
        }

        public static string NombreTienda { get { return "Electrodomesticos Pepe Peposo"; } }

        /// <summary>
        /// convierto los item de la lista en un valor numerico y retorna el item de la lista con el valor numero como indice
        /// </summary>
        public static string Oferta
        {
            get
            {
                int random =  rnd.Next(list.Count);
                list[random].AplicarDescuento();
                return list[random].ToString();
            }
        }
        /// <summary>
        /// recibe un producto y lo agrega a la lista siempre y cuando este no este repetido y la lista tenga espacio
        /// </summary>
        /// <param name="prod"></param>
        /// <returns>retorna true si lo pudo agregar o false si no fue exitosa la operacion</returns>
        public  static bool AgregarProducto(Producto prod)
        {
            if(list.Count < capacidadTienda)
            {
                if (list != prod)
                {
                    return list + prod;
                }
            }

            return false;
        }

        public static string InfoTienda()
        {
            StringBuilder sb = new StringBuilder();

            foreach(Producto prod in list)
            {
                sb.AppendLine(prod.ToString());
            }
            return sb.ToString();
        }

        
    }
}
