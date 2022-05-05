using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Dispositivo
    {
        private static List<Aplicacion> appInstaladas;
        private static SistemaOperativo sistemaOperativo;
        /// <summary>
        /// constructor encargado de crear un dispositvo instanciando la lista de aplicaciones instaladas y 
        /// asignandole el sistema operativo Android como default
        /// </summary>
        static Dispositivo()
        {
            appInstaladas = new List<Aplicacion>();
            sistemaOperativo = SistemaOperativo.ANDROID;
        }

        //METODOS
        /// <summary>
        /// instalar app se encarga de agregar una aplicacion a la lista, siempre y cuando el sistema operativo
        /// soportado de la app sea el mismo que el del dispositivo
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static bool InstalarApp(Aplicacion app)
        {
            if(app.SistemaOperativo != sistemaOperativo)
            {             
                return false;
            }
            return appInstaladas + app; ;
        }


        /// <summary>
        /// obtiene toda la informacion del dispositivo, es decir, primero informa que sistema operativo esta usando
        /// al usuario, despues le informa al usuario que aplicaciones tiene instaladas y las caracteristicas
        /// de cada aplicacion
        /// </summary>
        /// <returns></returns>
        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"SISTEMA OPERATIVO: {sistemaOperativo}");
            foreach (Aplicacion app in appInstaladas)
            {
                sb.AppendLine(app.ObtenerInformacionApp());
            }
            return sb.ToString();
        }
    }
}
