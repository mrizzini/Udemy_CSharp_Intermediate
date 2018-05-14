using System;

namespace Exercises
{

    public class Stack
    {
        // var stack = new Stack();
        
       public void Push(object obj)
       {
           System.Console.WriteLine("Push");

           if (obj == null)
           {
               throw new InvalidOperationException("Canot be null");
           }

           

        //    stack.Push(obj);
       }

       public object Pop()
       {
           System.Console.WriteLine("Pop:");
        //    return stack.Pop();
           return 10;
           
       }

       public void Clear()
       {
           System.Console.WriteLine("Clear");
       }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // System.Console.WriteLine(stack.Pop());
            // System.Console.WriteLine(stack.Pop());
            // System.Console.WriteLine(stack.Pop());
            
        }
    }
}
