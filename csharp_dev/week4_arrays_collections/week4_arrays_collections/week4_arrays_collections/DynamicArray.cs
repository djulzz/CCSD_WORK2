using System;
using System.Collections.Generic;
using System.Text;

namespace week4_arrays_collections
{
    public class DynamicArray
    {
        private double[] m_array;
        private int m_NumberOfValuesAppended;


        public DynamicArray()
        {
            m_array = new double[1];
            m_NumberOfValuesAppended = 0;
        }

        void AppendNewValue( double v )
        {
            // if my array is too small, then attempt at
            // storing elements anyway
            if(m_NumberOfValuesAppended <= m_array.Length )
            {
                m_array[m_NumberOfValuesAppended - 1] = v;
            } else
            {
                // save M-array to a temporary array, save
                // re - allocate m_array to be one block bigger
                // copy save array back to m_array
                // increment the variable "m_NumberOfValuesAppended"
            }
        }
    }
}
