using System;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;


        public  Producto(string codigoDeBarras, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarras;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        /// <summary>
        /// devuelve la converssion explicita de un objeto a string
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        //public static bool operator ==(Producto p1, Producto p2)
        //{
        //    return p1.codigoDeBarra == p2.codigoDeBarra;
        //}

        //public static bool operator !=(Producto p1, Producto p2)
        //{
        //    return !(p1.codigoDeBarra == p2.codigoDeBarra);
        //}


        public static bool operator ==(Producto p, string marca)
        {
            return p.marca == marca;
        }

        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1.marca == marca);
        }
        
        public static bool operator ==(Producto p1, Producto p2)
        {
            return (p1.marca == p2.marca) && (p1.codigoDeBarra == p2.codigoDeBarra);
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !((p1.marca == p2.marca) && (p1.codigoDeBarra == p2.codigoDeBarra));
        }

        public static string MostrarProducto(Producto p)
        {
            return $" El codigo de barra del producto es {p.codigoDeBarra} y la marca es {p.marca} y el precio es {p.precio}";
        }




    }
}
