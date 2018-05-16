using System;

namespace AbstractClassesAndMembers
{
    public class Circle : Shape
    {
        // override draw method
        public override void Draw()
        {
            System.Console.WriteLine("Draw a circle");
        }

    }

}