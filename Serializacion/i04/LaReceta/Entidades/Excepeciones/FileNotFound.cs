using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepeciones
{
    public class FileNotFound : Exception
    {
        public FileNotFound()
        {
        }

        public FileNotFound(string message) : base(message)
        {
        }

        public FileNotFound(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FileNotFound(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
