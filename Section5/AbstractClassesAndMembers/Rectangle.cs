using System;

namespace AbstractClassesAndMembers
{
    public class Rectangle : Shape
    {
        // override draw method
        // if we don't do this, it won't run because we call this abstract in Shape
        public override void Draw()
        {
            System.Console.WriteLine("Draw a rectangle");
        }

    }

}