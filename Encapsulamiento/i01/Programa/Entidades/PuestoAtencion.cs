using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
   
    public class PuestoAtencion
    {
        public enum EPuesto
        {
            Caja1,
            Caja2
        }

        private static int numeroActual;
        private EPuesto puesto;

       public PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }
        public PuestoAtencion(EPuesto puesto)
        {
            this.puesto = puesto;
        }

        public int NumeroActual
        {
            get { return ++PuestoAtencion.numeroActual; }// prre incremento, primero se incrementa despues se retorna
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(2000);
            return true;
        }


    }
}
