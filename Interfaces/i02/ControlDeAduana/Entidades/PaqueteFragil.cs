using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PaqueteFragil : Paquete
    {
        public PaqueteFragil(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKG) 
            : base(codigoSeguimiento, costoEnvio, destino, origen, pesoKG)
        {

        }
        public override bool TieneProbiedad => true;

    }
}
