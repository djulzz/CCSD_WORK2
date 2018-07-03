using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRG_310_Week2
{
    public class Student
    {
        private String FirstName;

        public void ChangeFirstName( String input )
        {
            FirstName = input;
        }

        static public void ChangeFirstName(ref String FirstName, String input)
        {

        }

        static public String ChangeFirstName2(String input)
        {
            return input;
        }
    }
}