/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_mod_5;

/**
 *
 * @author Esposito
 */
public class Java_Mod_5 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Housing myHousing = new Housing();
        
        Housing housing2 = new Housing();
        
        int a = 2;
        System.out.println( myHousing.m_YearBuilt );
        System.out.println( myHousing.m_Address );
        //myHousing.initializeType();
        System.out.println( myHousing.type.price);
        
        int[] ar; // un initialized reference
        ar = new int[ 5 ];
        System.out.println( ar[ 0 ] );
        
    }
    
}
