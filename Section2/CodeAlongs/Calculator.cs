using System;
using System.Collections.Generic;

namespace CodeAlongs2
{
     public class Calculator
    {

    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            // numbers is an integer array. 
            // want to add all and return result
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
    }

}