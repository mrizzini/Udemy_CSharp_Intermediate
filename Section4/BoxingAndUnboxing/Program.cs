using System;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // All types in C# are either Value types or Reference types

            // Value types:
            // Stored on the stack (when program is executed, a limited amount of space and the memory is allocated to each thread of the program and this space is used to store simple values like primitive types)
            // Values on stack have a short lifetime. Get booted from stack as soon as they are out of the scope
            // All primitive types: byte, int, float, char, bool
            // The struct type

            // Reference types:
            // Stored in the heap (which is a larger amount of memory which is used to store objects that require a longer lifetime)
            // Any classes (Object, Array, String, DbMigrator, etc.)
            // An object reference can be implicitly converted to a base class reference

            // The Object class is the base of all classes in .NET Framework

            // Circle circle = new Circle();
            // Shape shape = circle;
            // object shape = circle;

            // We put a value type on the right side of an assignment operator
            // This is called BOXING

            // Boxing:
            // The process of converting a value type instance to an object reference

            int number = 10;
            object obj = number;
            // or
            object obj = 10;
            // 10 gets boxed by the CLR and stored in the heap instead of the stack

            // Unboxing
            object obj = 10;
            int number = (int)obj;
            // When we cast an object to an integer unboxing happens
            // The result is a new variable on the stack called number with value of 10

            // Boxing and Unboxing have a performance penalty b/c of the extra object creation 

            // Create object of type ARRAYLIST

            var list = new ArrayList();
            list.Add(1);
            list.Add("Mosh");
            list.Add(DateTime.Today);

            // var number = (int) list[1];

            var anotherList = new List<int>();
            anotherList.Add(2);

            // **When you're working with a class if you're calling a 
            // method and that method gets an argument of type Object
            // be aware that if you pass a value type there boxing is going to happen.
            // Use a generic implentation of that class if it exists

        }
    }
}
