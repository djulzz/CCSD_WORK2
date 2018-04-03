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

        public void Push( double v )
        {
            if(m_NumberOfValuesAppended == m_array.Length )
            {
                int old_size = m_array.Length;
                double[] temp = new double[m_array.Length];
                for (int i = 0; i < m_array.Length; i++)
                    temp[i] = m_array[i];

                m_array = new double[old_size + 1];
                for (int i = 0; i < old_size; i++)
                {
                    m_array[i] = temp[i];
                }
            }
            m_NumberOfValuesAppended++;
            m_array[m_NumberOfValuesAppended - 1] = v;
        }

        public void Debug()
        {
            for (int i = 0; i < m_NumberOfValuesAppended; i++)
                Console.WriteLine(m_array[i]);
        }
        public double this[int index]
        {
            get
            {
                return m_array[index];
            }
            set
            {
                m_array[index] = value;
            }
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
