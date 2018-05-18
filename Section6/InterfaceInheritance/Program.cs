using System;

namespace InterfaceInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Interfaces are not to be used for multiple inheritfance
            // They have nothing to do with inheritance

            // You can implement multiple interfaces

            // Inheritance - we write all the code in one class and then we don't have to type the code again, the sub class automatically inherits all that code

            // Interfaces - does not have any code, just methods. When we implent that interface in a class we have to type that method declaration again and then actually implement.
            // No re-usability, no code to inherit

            // A class implements an interface b/c an interface is a simply a contract.
            // It says any class that implements this interface should have a method that is public void and called Drop(), for example
            // We are confirming to a contract. We're making sure that the public interface of our class has the methods or members as decalred in the interface
        }
    }
}
