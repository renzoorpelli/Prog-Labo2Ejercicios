using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class GestionImpuestos
    {
        private List<IAduana> impuestoAduana;
        private List<IAfip> impuestoAfip;


        public GestionImpuestos()
        {
            impuestoAfip = new List<IAfip>();
            impuestoAduana = new List<IAduana>();
        }

        public decimal CalcularTotalImpuestosAduana()
        {
            decimal total = 0;
            foreach (IAduana impuestoDeAduana in this.impuestoAduana)
            {
                total += impuestoDeAduana.Impuestos;
            }
            return total;
        }

        public decimal CalcularTotalImpuestosAfip()
        {
            decimal total = 0;
            foreach (IAfip impuestoDeAfip in this.impuestoAfip)   
            {
                total += impuestoDeAfip.Impuestos;
            }
            return total;
        }

        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes)
        {
            foreach (Paquete paquete in paquetes)
            {
                RegistrarImpuestos(paquete);
            }
        }

        public void RegistrarImpuestos(Paquete paquete)
        {
            impuestoAduana.Add(paquete);
            if (paquete is IAfip)
            {
                IAfip paqueteAfip = (IAfip)paquete;
                impuestoAfip.Add(paqueteAfip);
            }
        }
    }
}
