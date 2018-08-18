
import java.util.*;

/**
 * 
 */
public class Rectangle implements IShape {

    /**
     * Default constructor
     */
    public Rectangle() {
    }

    /**
     * 
     */
    private double mWidth;

    /**
     * 
     */
    private double mHeight;

    /**
     * 
     */
    private void Rectangle() {
        // TODO implement here
    }

    /**
     * @param width 
     * @param height
     */
    public void Rectangle(double width, double height) {
        // TODO implement here
    }

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