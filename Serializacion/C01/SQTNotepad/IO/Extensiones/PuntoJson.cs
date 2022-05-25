using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using IO.Excepciones;

namespace IO
{
    public class PuntoJson <T> : Archivo, IArchivo<T>
        where T : class
    {
        public override string Extension 
        {
            get
            {
                return ".json";
            }
        }
        public void Guardar(string ruta, T contenido)
        {
            try
            {
                if (ValidarExtension(ruta) && ValidarArchivo(ruta))
                {
                    string json = JsonSerializer.Serialize(contenido, typeof(T));
                    SerializerJson(ruta, json);
                }
            }
            catch (Exception ex)
            {
                throw new ArchivoIncorrectoException("ERROR DESDE GUARDAR JSON", ex);
            }
        }


        public void GuardarComo(string ruta, T contenido)
        {
            try
            {
                if (ValidarExtension(ruta))
                {
                    string json = JsonSerializer.Serialize(contenido, typeof(T));
                    SerializerJson(ruta, json);
                }
            }
            catch (Exception ex)
            {
                throw new ArchivoIncorrectoException("ERROR DESDE GUARDAR COMO Json", ex);
            }
        }


        public T Leer(string ruta)
        {
            try
            {
                if (ValidarArchivo(ruta) && ValidarExtension(ruta))
                {
                    string json = DeserializerJson(ruta);
                    return JsonSerializer.Deserialize<T>(json);
                }
            }
            catch (Exception ex)
            {
                throw new ArchivoIncorrectoException("ERROR DESDE LEER JSON", ex);
            }
            return null;
        }
        private void SerializerJson(string ruta, string contenido)
        {
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                streamWriter.WriteLine(contenido);
            }
        }
        private string DeserializerJson(string ruta)
        {
            using (StreamReader streamReader = new StreamReader(ruta))
            {
                return streamReader.ReadToEnd();
            }
        }



    }
}
