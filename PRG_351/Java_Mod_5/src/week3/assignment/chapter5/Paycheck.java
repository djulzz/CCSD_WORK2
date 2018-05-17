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
public class Paycheck <T extends Number> {
    private HourlyRate< T > mHourlyRate;
    private NumberHours< T > mNumberHours;
    
    // this will prevent default paychecks from
    // being instanciated
    private Paycheck()
    {
    }

    public double ComputeSalary( )
    {
        boolean OT_work = ( mNumberHours.Hours().doubleValue() > 40.0 );
        if( OT_work == true ) {
            double salary = mNumberHours.Hours().doubleValue() * mHourlyRate.Rate().doubleValue() * ( 1.5 );
            salary += 40.0 * mHourlyRate.Rate().doubleValue();
            return salary;
        } else {
            double salary = mNumberHours.Hours().doubleValue() * mHourlyRate.Rate().doubleValue();
            return salary;
        }
    }
    public Paycheck( HourlyRate iHourlyRate, NumberHours iNumberHours ) {  
        mHourlyRate = new HourlyRate( iHourlyRate.Rate());
        mNumberHours = new NumberHours( iNumberHours.Hours());
    }
    
    public void setHourlyRate( T value ) {
        mHourlyRate.SetRate( value );
    }
    
    public static double Marshall_UserInput( String prompt1, String prompt2 ) {
        double return_value = 0;
        
        
        boolean valueEnteredCorrectly = false;
        double value = 0.0;
        while( valueEnteredCorrectly == false ) {
            System.out.println( prompt1 );
            try {
                Scanner console = new Scanner( System.in );
                double val =  console.nextDouble();
                if( val < 0 ) {
                    System.out.println( prompt2 );
                } else {
                    return_value = val;
                    valueEnteredCorrectly = true;
                }
            } catch ( Exception e) {
                String error_message = e.getMessage();
                System.out.println( "Oops - we caught an excception. Windows 10 says = " + error_message );
            }

        }
        return return_value;
    }

    public static void Unit_Test() {
        String prompt1 = "Enter an hourly rate\r\n";
        String prompt2 = "You need to enter a positive number for the hourly rate\r\n";
        
        String promptA = "Enter a number of hours\r\n";
        String promptB = "You need to enter a positive number for the number of hours\r\n";
        
        double hourly_rate = Marshall_UserInput( prompt1, prompt2 );
        double number_hours = Marshall_UserInput( promptA, promptB );
        
        System.out.println( hourly_rate + " " + number_hours );

        HourlyRate< Integer > iHourlyRate = new HourlyRate<  >( ( int )hourly_rate );
        NumberHours< Integer > iNumberHours = new NumberHours<  >( ( int )( number_hours ) );

        Double d;
        Paycheck< Integer > p = new Paycheck<  >( iHourlyRate, iNumberHours );
        Paycheck< Double > p2;
        double salary = p.ComputeSalary( );
        System.out.println( "Your salary is = " + salary );
    }
    
    
}
