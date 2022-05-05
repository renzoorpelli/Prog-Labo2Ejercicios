using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto: Vehiculo
    {
        ETipoAuto tipoAuto;

        public Auto(string nombre, int presionRuedas, ETipoAuto tipoAuto) :this(nombre, "Sin Marca", presionRuedas,  tipoAuto)
        {
            
        }
        public Auto(string nombre, string marcaRuedas, int presionRuedas, ETipoAuto tipoAuto) :base(nombre, marcaRuedas,presionRuedas)
        {
            this.tipoAuto = tipoAuto;
        }
        
        public ETipoAuto TipoAuto
        {
            get { return tipoAuto; }
            set { tipoAuto = value; }
        }

        public override string TipoDeVehiculo
        {
            get { return GetType().Name; }
        }

        protected override string MostrarInfo()
        {
            return $"{base.MostrarInfo()}{this.TipoDeVehiculo}\nTipo Auto: {this.TipoAuto}\n";
        }
    }
}
