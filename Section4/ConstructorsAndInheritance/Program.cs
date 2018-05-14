using System;

namespace ConstructorsAndInheritance
{

    public class Vehicle
    {
        // our vehicle class has 2 constructors
        // one is default/parameterless
        // other takes paraemter of a string

        private readonly string _registrationNumber;

        // public Vehicle ()
        // {
        //     System.Console.WriteLine("Vehicle is being initialized");
        // }

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;

            System.Console.WriteLine("Vehicle is being initialized. {0} ", registrationNumber);
        }
    }

    // Car class that derives from Vehicle
    public class Car : Vehicle
    {
        // the parameterless constructor of Vehicle gets executed
        // then car constructor gets executed

        // when we create an object of type Car the runtime first tries
        // to create a an object of type Vehicle. if we do not have a 
        // default/parameterless constructor in Vehicle, we need to use 
        // the base class in this Car constructor

        // DEFINE A CONSTRUCTOR
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            System.Console.WriteLine("Car is being initialized. {0}", registrationNumber);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Constructor Inheritance

            // Base class constructors are always executed first
            // Base class constructors are not inherited
            // So in a derived class you need to redefine your constructors

            // when we create this object the constructor of the base class is always executed first.
            var car = new Car("XYZ1234");
        }
    }
}
