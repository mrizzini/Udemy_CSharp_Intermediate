using System;
using System.Collections.Generic;

namespace CodeAlongs2
{
     public class Point
    {
        public int X;
        public int Y;

        public Point (int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // overload this method
        public void Move(Point newLocation)
        {
            // let's make sure the value passed in is not null
            if (newLocation == null)
            {
                throw new ArgumentNullException("newLocation");
            }
            // throwing exceptions are a way to show user the error
            // and the code will not continue on
            // Defensive Programming! 
            Move(newLocation.X, newLocation.Y);

            // INSTEAD OF USING THE BELOW
            // this.X = newLocation.X;
            // this.Y = newLocation.Y;
        }

    
 
 
    }
}