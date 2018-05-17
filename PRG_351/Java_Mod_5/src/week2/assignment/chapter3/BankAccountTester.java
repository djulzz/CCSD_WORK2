/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */



package week2.assignment.chapter3;

import week1.assignment.chapter1.*;
/**
 *
 * @author Esposito
 */
public class BankAccountTester {
    public static void main(String[] args)
    {
        BankAccount momsSavings = new BankAccount(1000);
        momsSavings.Withdraw(500);
        double remainingBalance = momsSavings.Withdraw(400);
        System.out.println( "E3.3 - Mommy  balance is " + remainingBalance + " USD");
        System.out.println( "Mommy predicted balance is 1100 USD");
        double newBalance = momsSavings.addInterest(10);
        System.out.println( "E3.4 - Mommy calculated balance is " + newBalance + "USD");
        
        
    }
}
