using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingConfigFile
{
    public class ConfigFileException : Exception
    {
        private ConfigFileException() { }

        public ConfigFileException( string error_message )
            : base( error_message )
        {
        }
    }
}
