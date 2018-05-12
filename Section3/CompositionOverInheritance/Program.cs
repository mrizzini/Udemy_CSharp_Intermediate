using System;

namespace CompositionOverInheritance
{
    class ProgramCompOverInherit
    {
        static void Main(string[] args)
        {

            // Cons of Inheritance:
            // - Easily abused by amateur designers/developers
            // - Large hierarchies
            // - Fragility
            // - Tightly coupling
            // if you change a class on top of hierarchy, all the classes inherited from that will be affected



            // Any inheritance relationship can be translated to Composition
            // Can result in great flexibility
            // We need to design classes so that a change in the class is isolated and has minimal impact on other classes in the system
            // We need to think in objects to do this
            // With Composition, we encapsulate some common functionality then we compost them together, we tied them together to create new classes with new capailities of the existing classes. We compose them together
            // Has zero or minimal impact on other classes

            // Great flexibility
            // Loose coupling

            // 2 types of relationships between classes:
            // Inheritance (Is-a)
            // Composition (Has-a)

            // Use both appropiately
        }
    }
}
