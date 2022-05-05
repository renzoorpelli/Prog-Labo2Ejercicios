using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiClase
    {
        private string value;
        public MiClase()
        {
            try 
            {
                MiClase.MiMetodoEstatico();//llamo a mi metodo estatico
            }
            catch (DivideByZeroException ex)// atrapo la excepcion dividir por cero
            {
                throw new UnaExcepcion("Excepcion 1 de MiClase", ex); // devuelvo una nueva excepcion del tipo UnaExcepcion
            }
        }
        public MiClase(string value)
        {
            this.value = value;
            MiClase miClase; 
            try
            {
                miClase = new MiClase();   // instancion un objeto del tipo mi clase
            }
            catch (UnaExcepcion ex) //atrapo la excepcion de una excepcion 
            {
                throw new UnaExcepcion("Excepecion 2 de MiClase", ex); // lanzo una nueva UnaExepcion
            }
        }

        public static bool MiMetodoEstatico()
        {
            throw new DivideByZeroException("Error al dividir por cero"); //lanzo excepcion de dividir por cero
        }
    }
}
