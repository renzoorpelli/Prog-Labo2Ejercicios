using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiExcepcion : Exception
    {

        public MiExcepcion(string msg) : base(msg)
        {

        }
        public MiExcepcion(string msg, Exception inner) : base(msg, inner)
        {

        }
    }
}
