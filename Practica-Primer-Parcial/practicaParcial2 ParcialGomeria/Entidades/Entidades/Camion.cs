using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion: Vehiculo
    {
        protected bool tieneGrua;


        public Camion(string nombre, string marcaRuedas, bool tieneGrua) :this(nombre, marcaRuedas, 40, tieneGrua)
        {

        }

        public Camion(string nombre, string marcaRuedas, int presionRueda, bool tieneGrua) 
            :base(nombre, marcaRuedas, presionRueda)
        {
            this.tieneGrua = tieneGrua;
        }

        public override string TipoDeVehiculo
        {
            get { return GetType().Name; }
        }

        protected override string MostrarInfo()
        {
            return $"{base.MostrarInfo()}\n {this.TipoDeVehiculo}\nTiene Grua: {this.tieneGrua}\n";
        }

        
        
    }
}
