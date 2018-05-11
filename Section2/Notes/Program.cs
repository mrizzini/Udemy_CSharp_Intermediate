using System;
using System.Collections.Generic;


namespace Notes
{
    class ProgramNotes2
    {
        static void Main(string[] args)
        {

            // CLASSES

            // A class is a building block of an application
            // App consists of multiple classes, each responsible for a particular behavior in an app. Overall these classes together provide the behavior expected from the app
            //  Maintainable, clean, robust, reliable application

            // Class is a type that we define and give it a responsibility depending on the kind of application

            // Data (represented by fields)
            // Behavior (represented by methods/functions)

            // Person Class: Properties and methods

            // Name: string
            // Age: byte
            // Height: float
            // Weight: byte

            // Walk()
            // Talk()
            // Eat()
            // Sleep()

            // Object is used interchangeably but it is fundamentally different than a class

            // An object is an INSTANCE of a class that resides in memory

            // Person is a class
            // John, Mary are instances of the class, the objects
            
            // Person class or person type define the blueprint from which we can create objects at runtime
            // These objects in memory talk to each other and we get the behavior expected from the app


            // Use PascalCase to name classes
            // can have fields and methods inside classes, which are members of the class

            public class Person
            {
                public string Name; // declaring field
                public void Introduce() // declaring method
                {
                    System.Console.WriteLine("Hi my name is " + Name);
                }
            }

            Person person = new Person(); // creating object
            // OR
            var person1 = new Person(); 

            // can access members of the objects or call its methods
            person.Name = "Mosh";
            person.Introduce();

            // We can have instance members and static members

            // Instance - accessible from an object
            var person = new Person();
            person.Introduce();

            // Static - accessible from the class, NOT an object
            Console.WriteLine();
            //  Console is the class. do not need to create a new console to access it
            // We use these to represent concepts that are singleton
            // We should have only one instance of this in memory
            // Don't need to create multiple Consoles
            DateTime.Now;

            // declaring static members:

            public class PersonStatic
            {
                public static int PeopleCount = 0;
            }


            // CONSTRUCTORS

            // A constructor is a method that is called when an instance of a class is created
            //  Why? To put an object in an early state, to initialize some of the fields

            public class Customer
            {
                // this is the constructor. it must have the same name as the class. NO return type, not even void
                //  we can do any type of initializtion here
                // creates default values
                public Customer()
                {
                }
            }

            public class Customer1
            {
                public string Name;
                public Customer1(string name)
                {
                    // this references current object
                    // what we get from the outside (the parameter), will be copied into the name field
                    this.Name = name;
                }
            }

            var customer = new Customer1("John");
            // constructor will be called and the string passed in will be copied to the name field

            // Constructor Overloading
            // can use different signatures to overload
            // in example above we could have:
            // public Customer() {...}
            // public Customer(string name) {...}
            // public Customer(int id, string name) {...}

            // This makes initialization easier. we may only know the name when creating the class, so we use the middle one


            // OBJECT INITIALIZERS

            // a syntax for quickly initializing an object without the need to call one of the constructors
            // Why? to avoid creating multiple constructors

            public class Person2
            {
                public Person2(int id) {}

                public Person2(int id, string firstName) {}

                public Person2(int id, string firstName, string lastName) {}
            }
            // this is messy. let's use an object initializer

            var personObjectInit = new Person2
                                    {
                                        FirstName = "Mosh",
                                        LastName = "Hamedani"
                                    };
            

            // METHODS

            // Signature of a method:
            // Name
            // Number and Type of parameters

            // Overloading:
            // Method w/ same name but different signatures

            // Params Modifier

            public class Calculator
            {
                public int Add(params int[] numbers) {}
            }
            
            var result = calculator.Add(new int[] {1, 2, 3, 4});
            //  OR MORE SIMPLY, USING PARAMS WE CAN DO BELOW
            var result2 = Calculator.Add(1, 2, 3, 4);


            // FIELDS

            // fields are like a variable that we declare at the class level
            // and we use that to store data about the class
            // some believe we should use constructors only when we need to initialize our fields based on the values passed from the outside. if the constructor has no parameters

            // can do this without a constructor if we have no parameter

            public class Customer3
            {
                List<Order> Orders = new List<Order>;
            }

            // Read only fields. this makes sure the field is only initialized once
            // creates safety in our app

            public class Customer4
            {
                readonly List<Order> Orders = new List<Order>;
            }

            // we will only have one list where we keep the orders

        }
    }
}
