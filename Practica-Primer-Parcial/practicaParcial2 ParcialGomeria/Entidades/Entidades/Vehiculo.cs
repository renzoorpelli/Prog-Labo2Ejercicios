using System;

namespace Entidades
{
    public enum EMarcaRuedas
    {
        Pirelli,
        GoodYear,
        Brigedstone
    }
    public enum ETipoAuto
    {
        Sedan,
        Hatchback,
        Coupe
    }
    public abstract class Vehiculo
    {
        protected string marcaRuedas;
        protected string nombre;
        protected int presionRuedas;

        public Vehiculo(string nombre, string marcaRuedas, int presionRuedas)
        {
           this.marcaRuedas = marcaRuedas;
           this.nombre = nombre;
           this.presionRuedas = presionRuedas;
        }

        public string MarcaRuedas
        {
            get { return marcaRuedas; }
            set { marcaRuedas = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int PresionRuedas
        {
            get { return presionRuedas;}
            set { presionRuedas = value; }
        }
        public abstract string TipoDeVehiculo { get; }
        protected virtual string MostrarInfo()
        {
            return $"Nombre: {this.Nombre} \n Marca Ruedas: {this.MarcaRuedas}\nPresion Ruedas {this.PresionRuedas}\nTipo Vehiculo: ";
        }

        public  override string ToString()
        {
            return this.MostrarInfo();
        }
    }
}
