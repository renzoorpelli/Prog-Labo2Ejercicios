using System;

namespace LogicaNegocio
{
    public class Validador
    {
        public static bool Validar(int valor, int minimo, int maximo)
        {
            bool validado = false;

            if(valor > minimo && valor < maximo)
                validado = true;

            return validado;
        }

        
    }
}
