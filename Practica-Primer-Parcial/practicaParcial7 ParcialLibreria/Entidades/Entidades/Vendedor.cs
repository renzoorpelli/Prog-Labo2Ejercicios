using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;

        //constructores
        private Vendedor () 
        {
            ventas = new List<Publicacion> ();
        }

        public Vendedor (string nombre) : this()
        {
            this.nombre = nombre;
        }

        //sobrecarga
        public static bool operator +(Vendedor venderdor, Publicacion publicacion)
        {
            if(venderdor is not null  || publicacion is not null)
            {
                if(publicacion.HayStock)
                {
                    venderdor.ventas.Add(publicacion);
                    publicacion.Stock--;
                    return true;
                }
            }
            return false;
        }

        //metodos
        public static string ObtenerInformacionDeVentas(Vendedor vendedor)
        {
            StringBuilder sb = new StringBuilder();
            float ganancia = 0;
            sb.AppendLine($"NOMBRE: {vendedor.nombre}");
            sb.AppendLine("---------------------");
            foreach(Publicacion publicacion in vendedor.ventas)
            {
                sb.AppendLine($"{publicacion.ObternerInformacion()}");
                ganancia += publicacion.Importe;
            }
            sb.AppendLine($"GANANCIA TOTAL DE ${ganancia}");
            return sb.ToString();
        }
    }
}
