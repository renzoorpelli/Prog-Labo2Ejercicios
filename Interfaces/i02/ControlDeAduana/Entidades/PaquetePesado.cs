using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PaquetePesado : Paquete, IAfip
    {
        public PaquetePesado(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKG)
            : base(codigoSeguimiento, costoEnvio, destino, origen, pesoKG)
        {

        }
        public override bool TieneProbiedad => false;

        decimal  IAfip.Impuestos
        {
            get
            {
                return costoEnvio * 0.25m;
            }
        }
        public override decimal AplicarImpuestos()
        {
            return costoEnvio + Impuestos + ((IAfip)this).Impuestos;
        }

    }
}
