using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercises
{

    public class Stack
    {
        // create this so we can store any object in the list, and readonly so we cannot change it accidently
        private readonly List<object> list = new List<object>();
        
       public void Push(object obj)
       {
           // throw exception if we receive a null object
           if (obj == null)
           {
               throw new InvalidOperationException("Canot be null");
           }

            // insert the obj we were passed in at the 0th index
            // list.Insert(0, obj);

            // add to end of the list
            list.Add(obj);
       }

       public object Pop()
       {
           if (list.Count == 0)
           {
               throw new InvalidOperationException("List is empty");
               
           }
            var lastIndex = list.Count - 1;
           // store element that will be removed
            var popped = list[lastIndex];
            // removes last element we added in
            list.RemoveAt(lastIndex);
            return popped;
           
       }

       public void Clear()
       {
            list.RemoveRange(0, list.Count);
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

            System.Console.WriteLine(stack.Pop());
            System.Console.WriteLine(stack.Pop());
            System.Console.WriteLine(stack.Pop());
            
            stack.Clear();
        }
    }
}
