using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using IO.Excepciones;
namespace IO
{
    public class PuntoTxt : Archivo, IArchivo<string>
    {
        public override string Extension
        {
            get
            {
                return ".txt";
            }
        }

        public void Guardar(string ruta, string contenido)
        {
            try
            {

                if(ValidarArchivo(ruta) && ValidarExtension(ruta))
                {
                    GuardarArchivoTexto(ruta, contenido);
                }
            }
            catch(Exception ex)
            {
                throw new ArchivoIncorrectoException("EXCEPCION DESDE GUARDADO TXT", ex);
            }
        }

        public void GuardarComo(string ruta, string contenido)
        {
            try
            {

                if (ValidarExtension(ruta))
                {
                    GuardarArchivoTexto(ruta, contenido);
                }
            }
            catch (Exception ex)
            {
                throw new ArchivoIncorrectoException("EXCEPCION DESDE GUARDADO TXT", ex);
            }
        }


        public string Leer(string ruta)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    return streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                throw new ArchivoIncorrectoException("ERROR DESDE LEER TXT", ex);
            }
        }

        private void GuardarArchivoTexto(string ruta, string contenido)
        {
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine(contenido);
            }
        }

       
    }
}
