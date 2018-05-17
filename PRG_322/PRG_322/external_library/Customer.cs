using System;
using System.Collections.Generic;
using System.Text;

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
        public String Value;
        public SSN(String s) { Value = s; }
    }

    public sealed class Customer
    {
        protected FirstName mFirstName;
        protected LastName mLastName;
        protected SSN mSSN;

        

        public Customer(
            FirstName firstname,
            LastName LastName, SSN SSN )
        {

        }

    }

}
