using System;
using System.IO;
using IO.Excepciones;
namespace IO
{
    public abstract class Archivo
    {
        public abstract string Extension { get; }

        public  bool ValidarArchivo(string ruta)
        {
            if (File.Exists(ruta))
            {
                return true;
            }
            return false;
        }

        public  bool ValidarExtension(string ruta)
        {
            if (Path.GetExtension(ruta) != Extension)
            {
                throw new ArchivoIncorrectoException($"El archivo no tiene la extensión {Extension}.");
            }
            return true;
        }
    }
}
