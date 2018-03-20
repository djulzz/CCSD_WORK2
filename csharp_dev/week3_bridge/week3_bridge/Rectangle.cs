using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_bridge
{
    public class Rectangle : IShape
    {
        private double m_length;
        private double m_width;

        public void Debug()
        {

        }

        public Rectangle( double length, double width )
        {
            m_length = length;
            m_width = width;
        }

        public double Length
        {
            set
            {
                m_length = value;
            }

            get
            {
                return m_length;
            }
        }

        public double getArea()
        {
            return m_length * m_width;
        }

        public double getPerimeter()
        {
            return (m_length + m_width) * 2.0;
        }
    }
}
