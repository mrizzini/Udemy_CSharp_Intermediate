using System;
using System.Collections.Generic;


namespace MethodOverriding
{

    class Program
    {
        static void Main(string[] args)
        {
            // Method Overriding
            // Modifiyng the implementation of an inherited method
            // We may want to modify the implentation of a method that we inherited from a base class

            // Method overloading - having a method with the same name but different signatures
            //  Method overwriding is about changing the implentation of an inherited method

            // This is one way to implement polymorphic behavior
            // virtual and override

            var shapes = new List<Shape>();
            // store different types of shapes in this list
            // every parameter of DrawShape will be a shape object or a type that derives from the shape class
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShape(shapes);
            
        }
    }
}


// Benefits of Polymorphism
// We used encapsulation such that we encapsulate the concept of drawing a circle as well as the properties or attributes about a circle in one unit
// As you add support for more shapes, it could get bulky if we don't do this
// Pieces of code that are related are all in one unit
// Nothing gets bulky