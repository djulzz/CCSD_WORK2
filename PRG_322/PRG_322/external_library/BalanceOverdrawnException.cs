﻿using System;
using System.Collections.Generic;
using System.Text;

namespace external_library
{
    [Serializable()]
    class BalanceOverdrawnException : System.Exception
    {
        public BalanceOverdrawnException() : base() { }
        public BalanceOverdrawnException(string message) : base(message) { }
        public BalanceOverdrawnException(string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected BalanceOverdrawnException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
}
