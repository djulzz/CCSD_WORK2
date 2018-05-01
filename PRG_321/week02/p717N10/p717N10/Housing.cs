using System;
using System.Collections.Generic;
using System.Text;

namespace p717N10
{
    public class Housing : IUnits
    {
        protected int m_YearBuilt;
        protected String m_Address;

        public Housing()
        {
            m_YearBuilt = 1980;
            m_Address = "Elm Street";
        }
        virtual public int NumberUnits()
        {
            return 4;
        }

        public override String ToString()
        {
            String s = "Year Built = " + m_YearBuilt + " - Address = " + m_Address;
            return s;
        }
        public virtual double GetRentalAmount()
        {
            return 1565.5;
        }
    }
}
