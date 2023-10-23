using System.Runtime.Serialization;

namespace sistemaCompra
{
    [Serializable]
    internal class passwordException : Exception
    {
        public passwordException()
        {
            MessageBox.Show("Invalido");
        }

        public passwordException(string? message) : base(message)
        {
        }

        public passwordException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected passwordException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}