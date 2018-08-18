
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Circle : IShape {

    private Circle() {
    }

    private double mRadius;

    /// <summary>
    /// @return
    /// </summary>
    public double Area() {
        // TODO implement here
        return Math.PI * mRadius * mRadius;
        //return Math.PI * Math.Pow(mRadius, 2.0);
    }

    /// <summary>
    /// @return
    /// </summary>
    public double Perimeter() {
        // TODO implement here
        return 2 * Math.PI * mRadius;
    }

    /// <summary>
    /// @return
    /// </summary>
    public String Type() {
        // TODO implement here
        return "Circle";
    }

    /// <summary>
    /// @param radius
    /// </summary>
    public Circle(double radius) {
        // TODO implement here
        mRadius = radius;
    }


}