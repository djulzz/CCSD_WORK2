using System;
using System.Collections.Generic;
using System.Text;

namespace week4_arrays_collections
{
    public class MorningEmployee
    {
        private int[] m_array;

        public MorningEmployee()
        {
            m_array = new int[10];
        }

        public int[] Array
            {
                get { return m_array; }

                set { m_array = value;  }
            }

            
    }
}
