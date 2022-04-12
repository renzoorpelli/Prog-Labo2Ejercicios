using System;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;


        public  Producto(string marca, string codigoDeBarras, float precio)
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

        public static string MostrarProducto(Producto p)
        {
            return $" MARCA PRODUCTO: {p.marca}, CODIGO BARRAS: {p.codigoDeBarra},  PRECIO UNITARIO: ${p.precio}";
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
        public static bool operator ==(Producto p1, Producto p2)
        {
            bool todoOk = false;
            if (!(p1 is null || p2 is null))
            {
                if (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
                {
                    todoOk = true;
                }
            }
            return todoOk;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p, string producto)
        {
            bool todoOk = false;
            if( p.codigoDeBarra == producto)
            {
                todoOk =  true;
            }
            return todoOk;
        }


        public static bool operator !=(Producto p1, string producto)
        {
            return !(p1 == producto);
        }



    }
}
