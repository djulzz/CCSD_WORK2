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
    public class Housing implements IUnits
    {
        public int m_YearBuilt;
        public String m_Address;
        public PaintType type;

//         this is the default constructor
        public Housing()
        {
            m_YearBuilt = 1980;
            m_Address = "Elm Street";
            //type = new PaintType();
            initializeType();
        }
        
        public Housing( int a, String b, int c )
        {
        }
        

        public Housing( int yearBuilt, String localAddress )
        {
            m_YearBuilt = yearBuilt;
            m_Address  = localAddress;
        }
        
        void initializeType()
        {
            type = new PaintType();
        }

        @Override
        public int NumberUnits()
        {
            return 4;
        }

        //@Override - ToStering is never defined in any parent class, therefore
        // it is non - sensical to attempt at redefining the behavior of ToString
        public String ToString()
        {
            String s = "Year Built = " + m_YearBuilt + " - Address = " + m_Address;
            return s;
        }
        public double GetRentalAmount()
        {
            return 1565.5;
        }
    }
