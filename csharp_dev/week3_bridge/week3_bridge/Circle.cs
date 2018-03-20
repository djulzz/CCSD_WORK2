using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_bridge
{
    public class Circle : IShape
    {
        private double m_radius;
        private double m_x;
        private double m_y;

        public Circle(double radius, double x, double y )
        {
            m_radius = radius;
            m_x = x;
            m_y = y;
        }

        public double Radius
        {
            set
            {
                if( value >= 0 )
                    m_radius = value;
            }

            get
            {
                return m_radius;
            }
        }

        public double getArea()
        {
            return Math.PI * m_radius * m_radius;
        }

        public double getPerimeter()
        {
            return 2 * Math.PI * m_radius;
        }
    }
}
