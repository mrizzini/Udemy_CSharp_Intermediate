using System;

namespace SealedClassesAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sealed classes are opposite of Abstract
            // Sealed Modifer: prevents derivation of classes or overriding of methods

            // Why? Sealed classes are slightly faster b/c of some run-time optimizations
            // Hardly used
            // Could mess with inheritance hierarchy
            // You cannot inherit from the String class
        }
    }
}
