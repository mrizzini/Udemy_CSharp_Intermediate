using System;

namespace Notes
{
    class ProgramNotes2
    {
        static void Main(string[] args)
        {

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

        }
    }
}
