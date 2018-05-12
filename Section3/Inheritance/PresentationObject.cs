using System;

namespace Inheritance
{
    // THIS IS OUR BASE CLASS
    public class PresentationObject
    {
        // define properties
        public int Width { get; set; }
        public int Height { get; set; }

        // declare methods
        public void Copy()
        {
            System.Console.WriteLine("Object copied to clipboard");
        }

        public void Duplicate()
        {
            System.Console.WriteLine("Object was dupilicated");
        }
    }
}
   