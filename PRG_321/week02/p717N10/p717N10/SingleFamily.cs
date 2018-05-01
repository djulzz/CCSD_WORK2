using System;
using System.Collections.Generic;
using System.Text;

namespace p717N10
{
    public class SingleFamily : Housing, IUnits
    {
        private double m_SquareFootage;
        private bool m_GarageAvailable;

        public double SquareFootage
        {
            set { m_SquareFootage = value;  }
            get { return m_SquareFootage; }
        }

        public override string ToString()
        {
            String old_content =  base.ToString();
            String new_Content = " - Sqft = " + m_SquareFootage + " - garage = ";
            if( m_GarageAvailable == true )
            {
                new_Content += " available";
            } else
            {
                new_Content += " NOT available";
            }
            return old_content + new_Content;
        }
        public bool GarageAvailable
        {
            set { m_GarageAvailable = value;  }
            get { return m_GarageAvailable;  }
        }
    }
}
