using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    // We want to encapsualte the behavior and the data related to that behavior in one unit
    public class Circle : Shape 
    {
        public override void Draw()
        {
            // base is a reference to the parent class
            // so we can write any code specific to the circle class itself
            // base.Draw();
            System.Console.WriteLine("Draw a circle");
            
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a rectangle");
            
        }
    }

    // we can add a new class that has NO impact on the shape b/c shape
    // knows nothing about triangle
    // Has no impact on rectangle or circle or canvas
    // New classes has no impact on existing one
    public class Trianle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a triangle");
        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        // public Position Position { get; set; }
        // public ShapeType Type { get; set; }

        // add method called Draw

        public virtual void Draw()
        {
            // this will be inherited from the derived classes. but the algorithm will be different for rectangle and circle
            // So we use virtual so we can change its implentation in a derived class
        }
    }
}