using System;

namespace i03
{
    public class ArchivoException : Exception
    {
        public ArchivoException()
        {
        }

        public ArchivoException(string message) : base(message)
        {
        }

        public ArchivoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
