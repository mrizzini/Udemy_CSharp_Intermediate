using System;

namespace AbstractClassesAndMembers
{
    public abstract class Shape
    {
        public int Width { get; set; }  
        public int Height { get; set; } 

        // we have common behaviors in here with some common properties
        // about the concept of a shape that we implement here
        // but we would like to leave the behaviors to the derived classes to implenent, like Draw()

        // public virtual void Draw()
        // {
        //     // Leave this method as empty. Can't define implentation
        // }

        public abstract void Draw(); 

        public void Copy()
        {
            System.Console.WriteLine("Copy shape into clipboard");
        }

        public void Select()
        {
            System.Console.WriteLine("Select the shape");
        }
    }

}