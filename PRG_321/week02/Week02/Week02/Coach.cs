using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week02
{
    public class Coach : Person
    {
        /// <summary>
        /// This is the Copy Constructor
        /// </summary>
        public Coach(Coach rhs)
        {
            m_FirstName = rhs.m_FirstName;
            m_LastName = rhs.m_LastName;
        }

        public Coach()
        {
            m_FirstName = "First";
            m_LastName = "Last";
        }

        public override string ToString()
        {
            String content = "";
            content += "First Name = " + m_FirstName;
            content += " - Last Name = " + m_LastName;
            return content;
        }
    }
}