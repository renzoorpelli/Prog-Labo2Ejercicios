using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepeciones
{
    public class InvalidOperation : Exception
    {
        public InvalidOperation()
        {
        }

        public InvalidOperation(string message) : base(message)
        {
        }

        public InvalidOperation(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidOperation(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
