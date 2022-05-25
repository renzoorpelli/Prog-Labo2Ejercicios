using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using IO.Excepciones;


namespace IO
{
    public class PuntoXml<T> : Archivo, IArchivo<T>
        where T : class
    {
        public override string Extension
        {
            get
            {
                return ".xml";
            }
        }

        public void Guardar (string ruta, T contenido)
        {
            try
            {
                if(ValidarArchivo(ruta) && ValidarExtension(ruta))
                {
                    Serializer(ruta, contenido);
                }
            }
            catch (Exception ex)
            {
                throw new ArchivoIncorrectoException("ERROR DESDE GUARDAR XML", ex);
            }
        }


        public void GuardarComo(string ruta, T contenido)
        {
            try
            {
                if (ValidarExtension(ruta))
                {
                    Serializer(ruta, contenido);
                }
            }
            catch (Exception ex)
            {
                throw new ArchivoIncorrectoException("ERROR DESDE GUARDAR COMO XML", ex);
            }
        }


        public T Leer(string ruta)
        {
            try
            {
                if (ValidarArchivo(ruta) && ValidarExtension(ruta))
                {
                    using (XmlTextReader xmlTextReader = new XmlTextReader(ruta))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(T));
                        return serializer.Deserialize(xmlTextReader) as T;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArchivoIncorrectoException("ERROR DESDE LEER XML", ex);
            }
            return null;    
        }
        private void Serializer(string ruta, T contenido)
        {
            using (XmlTextWriter xmlTextWriter = new XmlTextWriter(ruta, Encoding.UTF8))
            {
                xmlTextWriter.Formatting = Formatting.Indented;
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(xmlTextWriter, contenido);
            }
        }
    }
}
