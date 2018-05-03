/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package week1.assignment.chapter2;

import javax.swing.JFrame;

/**
 *
 * @author Esposito
 */
public class AssignmentJFrame {
    public static void Unit_Test() {
        Color c = new Color( 50, 100, 150 );
        JFrame f = new JFrame( );
        f.setSize(400, 400);
        f.getContentPane().setBackground( new java.awt.Color( c.R(), c.G(), c.B() ) );
        f.show();
    }
}
