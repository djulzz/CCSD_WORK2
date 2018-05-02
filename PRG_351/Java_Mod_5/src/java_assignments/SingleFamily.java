/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_assignments;

/**
 *
 * @author Esposito
 */
public class SingleFamily
{

        private double m_SquareFootage;
        private boolean m_GarageAvailable;

        
        public double GetSquareFootage()
        {
            return m_SquareFootage;
        }
        
        public void SetSquareFootage(double v)
        {
            m_SquareFootage = v;
        }


        public String ToString()
        {
            String new_Content = " - Sqft = " + m_SquareFootage + " - garage = ";
            if( m_GarageAvailable == true )
            {
                new_Content += " available";
            } else
            {
                new_Content += " NOT available";
            }
            return new_Content;
        }
        
        public void SetGarageAvailable( boolean input )
        {
            m_GarageAvailable = input;
        }
        
        public boolean GetGarageAvailable( )
        {
            return m_GarageAvailable;
        }

    }  

