using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    // Canvas class
    // has a method that receives a list of shapes
    public class Canvas
    {
        public void DrawShape(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                // switch (shape.Type)
                // {
                //     case ShapeType.Circle:
                //         System.Console.WriteLine("Draw a circle");
                //         break;

                //     case ShapeType.Rectangle:
                //     System.Console.WriteLine("Draw a rectangle");
                //     break;

                //     case ShapeType.Triangle:
                //     System.Console.WriteLine("Draw a triangle");
                //     break;
                // }

                // instead of using the above, we simply call the draw method of the shape
                // every parameter of DrawShape will be a shape object or a type that derives from the shape class
                // so when we call this method we are talking about shapes but at runtime that shape object might be a circle or rectangle.
                // so the draw in the circle class might be called
                // or draw in rectangle might be called
                // THIS IS POLYMORPHISM
                shape.Draw();
            }
        }
    }
}
