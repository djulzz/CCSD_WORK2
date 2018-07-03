using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace external_library
{
    public class FirstName
    {
        public String Value;
        public FirstName(String s) { Value = s; }
    }
    public class LastName
    {
        public String Value;
        public LastName(String s) { Value = s; }
    }

    public class SSN
    {
        SSNMalFormedException e;
        public String Value;
        public SSN(String s)
        {
            Value = s;
            e = new SSNMalFormedException();
            int sz = s.Length;
            if( sz != 11 )
            {
                throw e;
            }
            // make sure we include 2 hyphens
            // make sure every character excepts hyphens is a digit3
        }
    }

    [Serializable]
    public sealed class Customer
    {
        protected FirstName mFirstName;
        protected LastName mLastName;
        protected SSN mSSN;

        

        public Customer(
            FirstName firstname,
            LastName LastName, SSN SSN )
        {
            mFirstName = firstname;
            mLastName = LastName;
            mSSN = SSN;
        }

        public void Serialize( String filename )
        {
            //IFormatter formatter = new SoapFormatter();
            //Stream stream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
            //formatter.Serialize(stream, this );
            //stream.Close();
        }

    }

}
