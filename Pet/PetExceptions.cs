using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet
{
    public class PetDeserializationException : Exception
    {
        public PetDeserializationException() { }

        public PetDeserializationException(string message) : base(message) { }

        public PetDeserializationException(string message, Exception inner) : base(message, inner) { }
    }
}
