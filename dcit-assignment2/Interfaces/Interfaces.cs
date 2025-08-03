namespace Interfaces
{
    //Base class
    public interface Imovable
    {
        void move();
    }

    // Derived classes
    public class Car : Imovable
    {
        public void move() => Console.WriteLine("Car is moving...");
    }

    public class Bicycle : Imovable
    {
        public void move() => Console.WriteLine("Bicycle is moving..");
    }

    //  Main
    internal class Interfaces
    {
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Instance of Car and Bicycle classes

            Car myCar = new Car();
            myCar.move();

            Bicycle myBicycle = new Bicycle();
            myBicycle.move();

        }
    }
}
