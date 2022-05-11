using System;
using Entidades;
namespace ContabilidadConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura,Recibo> documentosContables = new Contabilidad<Factura,Recibo>();

            //---------factura-------------
            Factura fac1 = new Factura(23);
            Factura fac2 = new Factura(25);
            //---------recibo-------------
            Recibo rec1 = new Recibo(20);
            Recibo rec2 = new Recibo(22);

            documentosContables += fac1;
            documentosContables += fac2;
            documentosContables += rec1;
            documentosContables += rec2;



        }
    }
}
