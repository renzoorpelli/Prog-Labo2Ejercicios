using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        protected EMarca marca = EMarca.MarcaNoInformada;
        protected string modelo;
        protected float precio;


        public Producto (string modelo, float precio)
        {
            
            this.modelo = modelo;
            this.precio = precio;
        }

        public Producto(string modelo, float precio, EMarca marca) :this(modelo, precio)
        {
            this.marca = marca;
        }

        public abstract string Garantia { get; }
        public abstract int PorcentajeDescuento { get; }

        public void AplicarDescuento()
        {
            this.precio = this.precio - ((this.precio * PorcentajeDescuento) / 100);
        }

        /// <summary>
        /// se fija si existe dos productos del mismo tipo comparando por marca, modelo y nombre de typo (celular, televisor)
        /// </summary>
        /// <param name="p1">un producto</param>
        /// <param name="p2">un producto</param>
        /// <returns></returns>
        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1.marca == p2.marca && p1.modelo == p2.modelo && p1.GetType().Name == p2.GetType().Name;
        }
        /// <summary>
        /// se fija si los productos son distintos al concepto de la funcion de arriba
        /// </summary>
        /// <param name="p1">un producto</param>
        /// <param name="p2">un producto</param>
        /// <returns></returns>
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// recibe un producto y se fija que el producto que recibe este en la lista, 
        /// </summary>
        /// <param name="listProd">lista de productos</param>
        /// <param name="p2">un producto</param>
        /// <returns>de estar retorna true y de no estar retorna false</returns>
        /// 
        public static bool operator ==(List<Producto> listProd, Producto p2)
        {
            foreach (Producto producto in listProd)
            {
                if (producto == p2)
                {
                    return true;
                }
            }
            return false;
            
        }
        /// <summary>
        /// ecibe un producto y se fija que el producto que recibe no este en la lista
        /// </summary>
        /// <param name="listProd">lista producto</param>
        /// <param name="p2">un producto</param>
        /// <returns>retorna falses</returns>
        public static bool operator !=(List<Producto> listProd, Producto p2)
        {
            return !(listProd == p2);
        }

        /// <summary>
        /// recibe una lista y un producto y si el producto no esta en la lista procede a agregarlo
        /// </summary>
        /// <param name="listProd"></param>
        /// <param name="p2"></param>
        /// <returns>returna true si la operacion fue exitosa o false si ya estaba en la lista</returns>
        public static bool operator +(List<Producto> listProd, Producto p2)
        {
            if(listProd != p2)
            {
                listProd.Add(p2);
                return true;
            }

            return false;
        }

        /// <summary>
        /// sobrecargo el metodo toString para que devuelva toda la informacion del producto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"MODELO: {this.modelo}\nPRECIO: {this.precio}\nMARCA: {this.marca}\nGARANTIA: {this.Garantia}";
        }

    }
}
