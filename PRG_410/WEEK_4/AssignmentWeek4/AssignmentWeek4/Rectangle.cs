
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Rectangle : IShape {

    private Rectangle() {
    }

    private double mWidth;

    private double mHeight;


    /// <summary>
    /// @param width 
    /// @param height
    /// </summary>
    public  Rectangle(double width, double height) {
        mWidth = width;
        mHeight = height;
    }

    /// <summary>
    /// @return
    /// </summary>
    public double Area() {
        // TODO implement here
        return mWidth * mHeight;
    }

    /// <summary>
    /// @return
    /// </summary>
    public double Perimeter() {
        // TODO implement here
        return 2 * (mHeight + mWidth);
    }

    /// <summary>
    /// @return
    /// </summary>
    public String Type() {
        // TODO implement here
        return "Rectangle";
    }

}