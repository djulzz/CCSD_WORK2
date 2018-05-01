using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week02
{
    public class Person
    {
        protected String m_FirstName;
        protected String m_LastName;
        protected String m_SportType;

        public string FirstName
        {
            get { return m_FirstName; }
            set
            {
                m_FirstName = value;
            }
        }

        public string LastName
        {
            get { return m_LastName; }
            set
            {
                m_LastName = value;
            }
        }
    }
}