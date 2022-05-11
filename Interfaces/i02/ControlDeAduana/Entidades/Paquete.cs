using System;
using System.Text;
namespace Entidades
{
    public abstract class Paquete : IAduana
    {
        private string codigoSeguimiento;
        protected decimal costoEnvio;
        private string destino;
        private string origen;
        private double pesoKG;


        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKG)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.origen = origen;
            this.destino = destino;
            this.pesoKG = pesoKG;
        }
        public abstract bool TieneProbiedad { get; }


        public decimal Impuestos
        {
            get { return this.costoEnvio * 0.35m; }
        }

        public virtual decimal AplicarImpuestos()
        {
            return this.costoEnvio + Impuestos; 
        }


        public string ObtenerInformacionPaquete()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ORIGEN {this.origen}");
            sb.AppendLine($"DESTINO {this.destino}");
            sb.AppendLine($"CODIGO SEGUIMINETO {this.codigoSeguimiento}");
            sb.AppendLine($"PESO {this.pesoKG}");
            sb.AppendLine($"TOTAL ENVIO {this.costoEnvio}");
            return sb.ToString();
        }
    
        
    }
}
