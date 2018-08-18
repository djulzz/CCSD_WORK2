
import java.util.*;

/**
 * 
 */
public class Triangle implements IShape {

    /**
     * Default constructor
     */
    public Triangle() {
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
     * @param width 
     * @param height
     */
    public void Triangle(double width, double height) {
        // TODO implement here
    }

    /**
     * 
     */
    private void Triangle() {
        // TODO implement here
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