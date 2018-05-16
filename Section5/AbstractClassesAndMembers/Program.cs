using System;

namespace AbstractClassesAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract Modifier:
            // Indicates that a class or a member is missing implentation
            // And we leave it to the derived classes to provide an implentation for the method
            // Abstract methods are inherently virtual and can provide polymorphic behavior

            // Rules:

            // Do not include implentation. No body
                // public abstract void Draw();

            // If a member is declared as abstract, the containing class needs to be declared as abstract too
                // public abstract class Shape
                // {
                    // public abstract void Draw();
                // }

            // Must implement all abstract members in the base abstract class
                // public class Circle : Shape
                // {
                    // public override void Draw()
                    // {
                        // Implentation
                    // }
                // }

            // Cannot be instantiated
                // var shape = new Shape() WON'T WORK

            // Why use? When you want to provide some common behavior, while forcing other developers to follow your design

            // cannot instantiate Shape b/c it is abstract
            // var shape = new Shape();

            var circle = new Circle();
            circle.Draw();

            var rectable = new Rectangle();
            rectable.Draw();

        }
    }
}
