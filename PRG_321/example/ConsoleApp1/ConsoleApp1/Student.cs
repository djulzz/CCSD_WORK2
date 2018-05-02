using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student
    {
        public Student()
        {
            firstName = "Bob";
        }

        private String firstName;

        public String FirstName
        {
            set { firstName = value; }
            get { return firstName; }
        }

        public void SetFirstName( String iFirstName )
        {
            
            if( iFirstName == String.Empty )
            {
                return;
            }

            firstName = iFirstName;
        }

        public String GetFirstName()
        {
            return firstName;
        }
    }
}
