
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Rectangle : IShape {


    private double mWidth;

    private double mHeight;

    private Rectangle() {
        // TODO implement here
    }

    /// <summary>
    /// @param width 
    /// @param height
    /// </summary>
    public Rectangle(double width, double height) {
        // TODO implement here
        mWidth = width;
        mHeight = height;
    }

    /// <summary>
    /// @return
    /// </summary>
    public double Area()
    {
        // TODO implement here
        return mWidth * mHeight;
    }

    /// <summary>
    /// @return
    /// </summary>
    public double Perimeter()
    {
        // TODO implement here
        return 2 * mWidth * mHeight;
    }

    /// <summary>
    /// @return
    /// </summary>
    public String Type() {
        // TODO implement here
        return "Rectangle";
    }

}