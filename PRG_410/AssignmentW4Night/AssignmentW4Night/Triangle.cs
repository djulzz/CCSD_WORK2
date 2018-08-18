
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Triangle : IShape {


    private double mWidth;

    private double mHeight;

    /// <summary>
    /// @return
    /// </summary>
    public double Area()
    {
        // TODO implement here
        return mWidth * mHeight / 2;
    }

    /// <summary>
    /// @return
    /// </summary>
    public double Perimeter() {
        // TODO implement here
        double diag = Math.Sqrt(mWidth * mWidth + mHeight * mHeight);

        return ( mHeight + mWidth + diag);
    }

    /// <summary>
    /// @param width 
    /// @param height
    /// </summary>
    public Triangle(double width, double height) {
        // TODO implement here
        mWidth = width;
        mHeight = height;
    }

    private  Triangle() {
        // TODO implement here
    }

    /// <summary>
    /// @return
    /// </summary>
    public String Type()
    {
        // TODO implement here
        return "Right Triangle";
    }

}