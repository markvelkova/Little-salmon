using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stats
{

    public class StatsDeserializationException : Exception
    {
        public StatsDeserializationException() { }

        public StatsDeserializationException(string message) : base(message) { }

        public StatsDeserializationException(string message, Exception inner) : base(message, inner) { }
    }

}

