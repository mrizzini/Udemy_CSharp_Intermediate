using System;

namespace Inheritance
{
    class ProgramInheritance1
    {
        static void Main(string[] args)
        {
            // Inheritance:
            // A kind of relationship/association between two classes that allows one to inherit code from the other
            // Is-A relationship
            // A Car is a Vehicle

            // Benefits:
            // Code re-use 
            // Polymorphic behavior (powerful)

            // Vehicle is the PARENT or BASE class or SUPERCLASS
            // Car is the CHILD or DERIVED class or SUBCLASS

            // Classes can only have one parent

            // Create an object of type Text
            var text = new Text();
            text.Width = 100;
            text.Copy();
        }
    }
}
