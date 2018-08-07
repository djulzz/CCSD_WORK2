using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_SQL_From_File
{
    public class ConfigFileException : System.Exception
    {
        private ConfigFileException() { }

        public ConfigFileException(String message )
            : base( message ) {}
    }
}