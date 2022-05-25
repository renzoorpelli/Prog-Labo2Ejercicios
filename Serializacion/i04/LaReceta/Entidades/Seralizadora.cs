using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Text.Json;
using Entidades.Excepeciones;
namespace Entidades
{
    public class Seralizadora
    {
        private static string rutaBase;

        static Seralizadora()
        {
            DirectoryInfo info = Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\Archivos_Serializados2\\");
            Seralizadora.rutaBase = info.FullName;
        }

        public static void Guardar(string nombreArchivo, Persona p)
        {
            try
            {  
                using (XmlTextWriter xmlText = new XmlTextWriter($"{Seralizadora.rutaBase}{nombreArchivo}", Encoding.UTF8))
                {
                    XmlSerializer xml = new XmlSerializer(typeof(Persona));
                    xmlText.Formatting = Formatting.Indented;
                    xml.Serialize(xmlText, p);
                }
            }catch (DirectoryNotFoundException ex)
            {
                throw new PathNotFoundException("NO SE ECNONTRO EL PATH", ex);
            }
            catch(InvalidOperationException ex)
            {
                throw new InvalidOperation("FALLA EN EL NOMBRE", ex);
                //Console.WriteLine(ex.Message);
            }
        }


        public static Persona Leer(string nombreArchivo)
        {
            try
            {
                using (XmlTextReader xmlReader = new XmlTextReader($"{Seralizadora.rutaBase}{nombreArchivo}"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                    Persona persona = serializer.Deserialize(xmlReader) as Persona;
                    return persona;
                }
            }
            catch(FileNotFoundException ex)
            {
                throw new FileNotFound("EL ARHIVO NO EXISTE", ex);
            }
            catch (InvalidOperationException ex)
            {
                //throw new InvalidOperation("FALLA EN EL NOMBRE", ex);
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public static void Guardar_JSON(string nombreArchivo, Persona persona)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter($"{Seralizadora.rutaBase}{nombreArchivo}"))
                {
                    JsonSerializerOptions options = new JsonSerializerOptions();
                    options.WriteIndented = true;
                    string ser = JsonSerializer.Serialize(persona, options);

                    streamWriter.WriteLine(ser);
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new PathNotFoundException("NO SE ECNONTRO EL PATH", ex);
            }
        }

        public static Persona Leer_JSON(string nombreArchivo)
        {
            try
            {        
                using (StreamReader streamReader = new StreamReader($"{Seralizadora.rutaBase}{nombreArchivo}"))
                {
                    string jsonFile = streamReader.ReadToEnd();
                    return JsonSerializer.Deserialize<Persona>(jsonFile);
                }
            }
            catch (FileNotFoundException ex)
            {
                throw new FileNotFound("EL ARHIVO NO EXISTE", ex);
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new PathNotFoundException("NO SE ECNONTRO EL PATH", ex);
            }
            catch (InvalidOperationException ex)
            {
                //throw new InvalidOperation("FALLA EN EL NOMBRE", ex);
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
