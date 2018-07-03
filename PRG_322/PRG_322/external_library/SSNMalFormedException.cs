using System;
using System.Collections.Generic;
using System.Text;

namespace external_library
{
    [Serializable()]
    class SSNMalFormedException : System.Exception
    {
        public SSNMalFormedException() : base() { }
        public SSNMalFormedException(string message) : base(message) { }
        public SSNMalFormedException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected SSNMalFormedException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
}
