using System;
using System.Text;
using System.Collections.Generic;

namespace Entidades
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;

        //constructores
        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }

        public Publicacion (string nombre, int stock) :this(nombre)
        {
            this.stock = stock;
        }
        public Publicacion(string nombre, int stock, float importe) : this(nombre, stock)
        {
            this.importe = importe; 
        }

        // propiedades
        protected abstract bool EsColor { get; }

        public virtual bool HayStock 
        {
            get
            {
                return stock > 0 && importe > 0;
                
            }
        }

        public float Importe
        {
            get { return importe; }
        }

        public int Stock
        {
            get { return stock; }
            set 
            { 
                if(value >= 0)
                {
                    stock = value; 

                }
            }
        }

        //METODOS
        public override string ToString()
        {
            return this.nombre;
        }

        public string ObternerInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"NOMBRE: {this.nombre}");
            sb.AppendLine($"STOCK: {this.stock}");
            sb.AppendLine($"ES COLOR: {this.EsColor}");
            sb.AppendLine($"VALOR: {this.Importe}");
            return sb.ToString();

        }
    }

}
