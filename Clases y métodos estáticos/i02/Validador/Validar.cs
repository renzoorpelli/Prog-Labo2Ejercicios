using System;

namespace Validador
{
    public class Validar
    {
        public static bool ValidarRespuesta(char respuesta)
        {
            bool respuestaValidada;
            if (respuesta == 's')
                respuestaValidada = true;
            else
                respuestaValidada = false;
            return respuestaValidada;
        }

    }
}
