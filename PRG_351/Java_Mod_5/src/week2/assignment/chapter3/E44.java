/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package week2.assignment.chapter3;

import java.util.Scanner;
/**
 *
 * @author Esposito
 */
public class E44 {
    
    public static void Unit_Test()
    {
        int[] a = new int[ 2 ];
        System.out.println( "Input 2 integers");
        Scanner sc = new Scanner(System.in);

        a[ 0 ] = sc.nextInt();
        a[ 1 ] = sc.nextInt();

        int sum  = a[ 0 ] + a[ 1 ];
        int diff = a[ 0 ] - a[ 1 ];
        int product = a[ 0 ] * a[ 1 ];
        double avg = ( double )sum / 2.0;
        int dist = Math.abs( diff );
        int max = Math.max( a[0], a[1]);
        int min = Math.min( a[0], a[1]);
        

        System.out.format("sum     = %+04d%n", sum );
        System.out.format("diff    = %+04d%n" , diff );
        System.out.format("product = %+04d%n" , product );
        System.out.format("avg     = %+04f%n" , avg );
        System.out.format("dist    = %+04d%n" , dist );
        System.out.format("max     = %+04d%n" , max );
        System.out.format("min     = %+04d%n" , min );
    }
}
