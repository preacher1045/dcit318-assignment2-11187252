namespace InheretanceOverride
{

    // Base class
    public class Animal
    {
        // Auto-Property
        public string Name { get; set; }

        // Constructor
        public Animal(string name)
        {
            Name = name;
        }

        // Method
        public virtual void MakeSound() => Console.WriteLine($"{Name} squils.....");

    }

    // Derived classes
    public class Dog : Animal
    {

        public Dog(string name) : base(name) { }

        public override void MakeSound() => Console.WriteLine("Bark....");
    }

    public class Cat : Animal 
    {
        public Cat(string name) : base(name) { }

        public override void MakeSound() => Console.WriteLine("Meow....");
    }

    //Main
    internal class Inheretance_Method_Overriding
    {
        static void Main(string[] args)
        {
            //Instance of Animal class : Base class
            Animal myAnimal = new Animal("Benny");
            myAnimal.MakeSound();

            //Instance of derived class : Dog
            Dog myDog = new Dog("Rex");
            myDog.MakeSound();

            //Instance of derived class : Cat
            Cat myCat = new Cat("Lenny");
            myCat.MakeSound();
        }
    }
}
