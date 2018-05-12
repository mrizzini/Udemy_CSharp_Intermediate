using System;
using System.Collections.Generic;

namespace One
{
    public class StopWatch
    {

        // public DateTime Start { get; set; }
        public DateTime Start()
        {
            var Start = DateTime.Now;
            return Start;
        }
        // public DateTime End { get; set; }
        public DateTime End()
        {

            var End = DateTime
            return End;
        }


        public TimeSpan Duration
        {
            get 
            {
                var timeSpan = End - Start;

                return timeSpan;
            }
        }




    }
}