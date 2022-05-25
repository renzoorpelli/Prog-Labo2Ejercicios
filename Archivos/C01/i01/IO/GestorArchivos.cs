using System;
using System.IO;

namespace IO
{
    public class GestorArchivos
    {

        public static void GuardarArchivo(string ruta, string informacion)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(ruta))
                {
                    sw.WriteLine(informacion);
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static string LeerArchivo(string ruta)
        {
            try
            {
                using (StreamReader sw = new StreamReader(ruta))
                {
                    return sw.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return null;
        }

    }
}
