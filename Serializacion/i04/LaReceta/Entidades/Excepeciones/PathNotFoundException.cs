using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepeciones
{
    public class PathNotFoundException : Exception
    {
        public PathNotFoundException(string message) : base(message)
        {

        }
        public PathNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
