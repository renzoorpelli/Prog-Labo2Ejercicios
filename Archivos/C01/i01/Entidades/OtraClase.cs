using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OtraClase
    {
        public void MiMetodoInstancia() // creo una metodo de instacioa
        {
            MiClase miClase;
            try
            {
                miClase =  new MiClase("a");    // instancio un objeto con el atrubuto vacio
            }
            catch (UnaExcepcion ex) // atrapo una excepcion del tipo UnaExcepcion
            {
                throw new MiExcepcion("Esta es la excepcion de MiExcepcion, desde la clase OtraClase", ex); // lanzo una nueva Excepcion del tipo MiEXCEPCXION
            }
        }


    }
}
