using System.Security.Cryptography.X509Certificates;

namespace AbstractClasses_Methods
{
    // Abstract Class
    public abstract class Shape
    {
        public abstract double getArea();
    }

    // Derived Classes

    public class Circle : Shape
    {
        // Auto- Property
        public double Radius { get; set; }

        // Constructor
        public Circle(double radius) => Radius = radius;

        // Overriding getArea() method from abstract class : Shape
        public override double getArea() => Math.PI * Radius * Radius;
    }

    public class Rectangle : Shape
    {
        // Auto- Properties
        public int Width { get; set; }
        public int Height { get; set; }

        // Constructor
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        // Overriding getArea() method from abstract class : Shape
        public override double getArea() => Width * Height;
    }

    // Main

    internal class Abstract_Classes_Methods
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Circle myCircle = new Circle(20);
            double rad = myCircle.getArea();
            Console.WriteLine(rad);

            Rectangle myRectangle = new Rectangle(20, 45);
            double area = myRectangle.getArea();
            Console.WriteLine(area);
        }
    }
}
