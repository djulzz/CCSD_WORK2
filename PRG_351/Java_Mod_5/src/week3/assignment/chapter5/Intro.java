/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package week3.assignment.chapter5;

import java.util.*;
/**
 *
 * @author Esposito
 */
public class Intro {
    

    public static void Run() {
        int a = 2;
        int var = 0;
        if( a == 1 )
        {
            System.out.println( "a  = 1 ");
            a = a + 4;
        } else
        {
            System.out.println( "a is not equal to one");
        }
        
        a = 0;
        int b =  ( a < 0 ) ? 1 : 5;
        if( a < 0 ) {
            b = 1;
        } else {
            b = 5;
        }
        
        char letter = 'n';
        Scanner s = new Scanner( System.in );
        /*
        * == comparison
        * != inequality
        * >= Greater or equal to
        * <= Lesser or equal to
        * && AND
        * || OR
        */
        while( letter != 'y'  ) {
            System.out.println("Enter a response (y/n)");
            letter = s.next().charAt(0);
            String myString = s.next();
            letter = myString.charAt(0);
        }

        for( int i = 0; i < 6; i++ )
        {
            
        }
        
    for( int j = 0; j < 5; j++ ) {

}
}
}
