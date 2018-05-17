/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package week3.assignment.chapter5;

/**
 *
 * @author Esposito
 */
public class NumberHours <T extends Number >{
    
    private T value;
    
    public T Hours() {
        return value;
    }
    
 /**
  * @brief Retrieves the number of hours 
  * @func NumberHours
  * @param v the value to set the number of hours to.
  */
    public NumberHours( T v ) {
        T reference = (T)((Integer)0);
        if( v.intValue() >= 0 )
        {
            value = v;
        }
        
    }
    
    private NumberHours()
    {
        //value = 0;
    }
    
    public void SetHours( T nHours ) {
        value = nHours;
    }
}
