using System;
using System.Collections.Generic;

namespace One
{
    public class StopWatch
    {

        // public DateTime Start { get; set; }
        public DateTime Start()
        {
            System.Console.WriteLine("Starting stopwatch");
            var Start = DateTime.Now;
            return Start;
        }
        // public DateTime End { get; set; }
        public DateTime End()
        {
            System.Console.WriteLine("Ending stopwatch");
            var End = DateTime.Now;
            return End;
        }

        public void Duration(DateTime start, DateTime end)
        {
            System.Console.WriteLine(end - start);
        }


        // public TimeSpan Duration
        // {
        //     get 
        //     {
        //         var timeSpan = End - Start;

        //         return timeSpan;
        //     }
        // }




    }
}