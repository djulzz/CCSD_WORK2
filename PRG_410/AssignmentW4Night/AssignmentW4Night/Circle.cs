
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Circle : IShape {


    public double Radius
    {
        set
        {
            if (value < 0)
                return;
            mRadius = value;
        }

        get
        {
            return mRadius;
        }
    }
    private double mRadius;

    public double Area() {
        // TODO implement here
        return Math.PI * Math.Pow(mRadius, 2);
        //return Math.PI * mRadius * mRadius;
    }

    /// <summary>
    /// 
    /// </summary>
    public void Foo()
    { }
    public double Perimeter() {
        // TODO implement here
        return 2 * mRadius * Math.PI;
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
        mRadius = radius;
    }

    private Circle() {
        // TODO implement here
    }

}