using System;

namespace UpcastingAndDowncasting
{

    public class Shape
    {
        // declare properties
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        // method
        public void Draw()
        {
            // System.Console.WriteLine();
        }
    }

    // class that derives from Shape
    public class Text : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
    }



    class Program
    {
        static void Main(string[] args)
        {
            // UPCASTING
            // Conversion from a derived class to a base class

            // Circle circle = new Circle();
            // Shape shape = circle;
            // This is implicit. No conversion is required

            // DOWNCASTING
            // Conversion from a base class to a derived class

            // Circle circle = new Circle();
            // Shape shape = circle;
            // Circle anotherCircle = (Circle)shape;

            // This can throw an exception. To avoid this, use as keyword

            // Car car = obj as Car;
            // if (car != null)
            // {
                // 
            // }

            // We can use the is keyword to check if object is a Car
            // if (obj is Car)
            // {
                // Car car = (Car) obj;
            // }

            Text text = new Text();
            // Upcasting:
            Shape shape = text;
            // Both this text and shape object are references to the same object in memory, just with different views

            text.Width = 200;
            shape.Width = 100;
            // This will display 100
            System.Console.WriteLine(text.Width);

            // Downcasting
            // At compile time, our shape object will be type Shape
            // But at run time it will be type Text
            // So we need to downcast
            Shape shapeDown = new Text();
            Text text = (Text) shape;
            // or
            // Text text = shape as Text;
            // if (text != null)
            // {
                
            // }
            

        }
    }
}
