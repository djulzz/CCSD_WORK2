using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week02
{
    public class SportTeam
    {
        protected string m_address;
        protected Coach m_coach;

        public Coach Coach
        {
            get
            {
                return m_coach;
            }
            set
            {
                m_coach = value;
            }
        }

        public string Address
        {
            get { return m_address; }
            set
            {
                m_address = value;
            }
        }

        public virtual String ShowClassName()
        {
            String s = "Sport Team";
            return s;
        }
    }
}