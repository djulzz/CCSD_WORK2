/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package week1.assignment.chapter1;

/**
 *
 * @author Esposito
 */
public class BankAccount {
    double balance;
    double interestRate;
    
    public BankAccount( double ibalance, double iinterestRate ) {
        balance = ibalance;
        interestRate = iinterestRate;
    }
    
    public String ToString()
    {
        String s = "Balance = " + balance  + " - Interest Rate = " + interestRate;
        return s;
    }
    
    public double ComputeBalanceAfter_Jordan( int numberYears )
    {
        double amount = balance;
        for( int i = 0; i < numberYears; i++ ) {
            amount = amount * ( 1.0 + interestRate );
        }  
        return amount;
    }
    
    public double ComputeBalanceAfter_Brandon( int numberYears )
    {
        double amount = balance;
        return amount * Math.pow((1 + interestRate ), numberYears);
    }     
    
    public double ComputeBalanceAfter( int numberYears, String method )
    {
        if( method.equals("Brandon") )
            return ComputeBalanceAfter_Brandon( numberYears );

        return ComputeBalanceAfter_Jordan( numberYears );
    }
    
    public static void Unit_Test()
    {
        BankAccount ba = new BankAccount( 1000, 0.05 );
        System.out.println( ba.ToString() );
        
        double finalBalance = ba.ComputeBalanceAfter(3, "Brandon");
        double finalBalanceJordan = ba.ComputeBalanceAfter(3, "Jordan");
        System.out.println( "Final Balance After 3 years (Brandon) = " + finalBalance );
        System.out.println( "Final Balance After 3 years (Jordan) = " + finalBalanceJordan );
    }
}
