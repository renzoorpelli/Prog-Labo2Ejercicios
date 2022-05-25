using System;
using Entidades;
using IO;
namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            OtraClase otraClase;
            string nombreArchivo = $"{DateTime.Today.Year}{DateTime.Today.Month}{DateTime.Today.Day}--{DateTime.Today.Hour}{DateTime.Today.Minute}.txt";
            string pathArchivo = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}";
            string pathCompleto = $"{pathArchivo}\\{nombreArchivo}";
            string mensaje = string.Empty;
            try
            {
                otraClase = new OtraClase();
                otraClase.MiMetodoInstancia();
            }
            catch (MiExcepcion ex)
            {
                //Console.WriteLine($"mensaje ex.Message");
                //Console.WriteLine(ex.Message);
                mensaje = $"{ex.Message}\n {ex.InnerException.Message}";
                GestorArchivos.GuardarArchivo($"{pathCompleto}", mensaje);
                Console.WriteLine($"Guardado en {pathCompleto}");
                Exception exInner = ex.InnerException;
                while (exInner != null)
                {
                    //Console.WriteLine(exInner.Message);
                    //GestorArchivos.GuardarArchivo($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\miArchivo.txt", exInner.Message);
                    exInner = exInner.InnerException;
                }
            }

            try
            {
                Console.WriteLine(GestorArchivos.LeerArchivo(pathCompleto));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
