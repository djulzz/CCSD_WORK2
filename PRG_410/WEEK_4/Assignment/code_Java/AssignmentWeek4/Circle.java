
import java.util.*;

/**
 * 
 */
public class Circle implements IShape {

    /**
     * Default constructor
     */
    public Circle() {
    }

    /**
     * 
     */
    private double mRadius;

    /**
     * @return
     */
    public double Area() {
        // TODO implement here
        return 0.0d;
    }

    /**
     * @return
     */
    public double Perimeter() {
        // TODO implement here
        return 0.0d;
    }

    /**
     * @return
     */
    public String Type() {
        // TODO implement here
        return "";
    }

    /**
     * @param radius
     */
    public void Circle(double radius) {
        // TODO implement here
    }

    /**
     * 
     */
    private void Circle() {
        // TODO implement here
    }

    /**
     * @return
     */
    abstract double Area();

    /**
     * @return
     */
    public abstract double Perimeter();

    /**
     * @return
     */
    public abstract String Type();

}