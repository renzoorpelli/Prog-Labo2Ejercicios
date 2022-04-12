using System;

namespace Calculadora
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero) {
            string numeroBinario = string.Empty;
            int calculador;

            while(numeroEntero > 0)
            {
                calculador = numeroEntero % 2;
                numeroEntero /= 2;
                numeroBinario = calculador.ToString() + numeroBinario;
            }

            return numeroBinario;
        }

        public static int ConvertirBinarioADecimal(int numeroEntero) 
        {
            int digitos;
            int numeroDecimal=0;
            int secuencia = 1;
            while (numeroEntero > 0)
            {
                digitos = numeroEntero % 10;
                numeroEntero /= 10;
                numeroDecimal = numeroDecimal + (digitos * secuencia);
                secuencia *= 2;
            }
            
            return numeroDecimal;
        }

        public static bool isNumberValid(int numero)
        {
            bool todoOk = false;

            if (numero > 0)
            {
                todoOk = true;
            }

            return todoOk;
        }
    }
}
