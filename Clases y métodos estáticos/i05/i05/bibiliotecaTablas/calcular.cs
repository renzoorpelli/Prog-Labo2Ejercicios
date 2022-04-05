using System;
using System.Text;

namespace bibiliotecaTablas
{
    public class calcular
    {
        public static string calcularTablas (int numeroIngresado)
        {
            string tabla;
            StringBuilder tablasNumero = new StringBuilder();
            for (int i = 0; i <= 10; i++)
            {
                tablasNumero.AppendLine($"{numeroIngresado} X {i} = {numeroIngresado * i}");
            }
            tabla = tablasNumero.ToString();
            return tabla;
        }
    }
}
