using System;

namespace Entidades
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion(string msg) : base(msg)
        {

        }
        public UnaExcepcion (string msg, Exception inner) :base(msg, inner)
        {

        }
    }  
}
