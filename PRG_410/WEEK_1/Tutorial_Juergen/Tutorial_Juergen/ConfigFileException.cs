using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tutorial_Juergen
{
    public class ConfigFileException : System.Exception
    {
        private ConfigFileException() { }

        public ConfigFileException(String message )
            : base( message ) {}
    }
}