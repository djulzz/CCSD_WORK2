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
public class HourlyRate< T extends Number > {
    private T value;
    
    private HourlyRate() {}
    public void SetRate( T rate ) {
        value = rate;
    }
    
    public HourlyRate( T v ) {
        value = null;
        T reference = (T)((Integer)0);
        if( v.intValue() >= 0 ) {
            value = v;
        }
    }
    // public double GetRate() as an alternative
    public T Rate() {
        return value;
    }
}
